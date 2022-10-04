using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System;
using System.Security.Cryptography;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using RecipeApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.AspNetCore.Authorization;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using LLBLGen.Linq.Prefetch;
using RecipeDB.DatabaseSpecific;
using RecipeDB.EntityClasses;
using RecipeDB.HelperClasses;
using RecipeDB.FactoryClasses;
using RecipeDB.Linq;

var builder = WebApplication.CreateBuilder(args);

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();
var connectionString = config["ConnectionStrings:RecipeDb"];

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey
            (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero
    };
});
builder.Services.AddAuthorization();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(c => c.AddDbProviderFactory(typeof(Npgsql.NpgsqlFactory)));

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials()); // allow credentials

app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

//Desrialize recipe file and category file
List<User>? savedUsers = new();
List<Recipe>? savedRecipes = new();
List<string>? savedCategories = new();

//Create list of recipes and list of categories
List<User> usersList = new List<User>();
List<Recipe> recipesList = new List<Recipe>();
List<string> categoryList = new List<string>();

// User register
app.MapPost("/register", async ([FromBody] UserDto newUser) =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        var metaData = new LinqMetaData(adapter);
        var users = metaData.User.Where(x => x.IsActive == true);
        var usernames = users.Select(x => x.Username);

        if (newUser.UserPassword.IsNullOrEmpty())
        {
            return Results.BadRequest("Invalid password!");
        }
        else if (newUser.Username.IsNullOrEmpty() || usersList.Exists(x => x.Username == newUser.Username))
        {
            return Results.BadRequest("Invalid user name");
        }

        CreatePasswordHash(newUser.UserPassword, out byte[] passwordHash, out byte[] passwordSalt);
        User addedUser = new User();
        addedUser.Id = new Guid().ToString();
        addedUser.Username = newUser.Username;
        addedUser.PasswordHash = passwordHash;
        addedUser.PasswordSalt = passwordSalt;

        usersList.Add(addedUser);
        //await SaveUserToJson();
        var stringToken = CreateToken(newUser.Username);
        return Results.Ok(stringToken);
    }
});

// User login
app.MapPost("/login", async ([FromBody] UserDto enteredUser, Microsoft.AspNetCore.Http.HttpResponse response) =>
{
    if (!usersList.Exists(x => x.Username == enteredUser.Username))
    {
        Results.Text("User not found");
        return Results.NotFound("User not found");
    }
    else if (enteredUser.Username.IsNullOrEmpty())
    {
        return Results.BadRequest("you entered empty user name!");
    }
    User? userData = usersList.FirstOrDefault((x) => x.Username == enteredUser.Username);
    if (!VerifyPassword(enteredUser.UserPassword, userData.PasswordHash, userData.PasswordSalt))
    {
        return Results.BadRequest("Password incorrect");
    }

    var token = CreateToken(enteredUser.Username);

    var refreshToken = GenerateRefreshToken();
    SetRefreshToken(refreshToken, token, userData, response);

    userData.RefreshToken = refreshToken.Token.ToString();
    //await SaveUserToJson();

    List<string> tokens = new List<string>()
    {
        token,
        refreshToken.Token.ToString()
    };
    return Results.Ok(tokens);
});

// Refresh token
app.MapPost("/refreshToken", async ([FromBody] string username, Microsoft.AspNetCore.Http.HttpRequest request, Microsoft.AspNetCore.Http.HttpResponse response) =>
{
    User? specifiedUser = new User();
    var refreshToken = request.Cookies["refreshToken"];
    if (!usersList.IsNullOrEmpty() && !username.IsNullOrEmpty() && usersList.Exists(x => x.Username == username))
    {
        specifiedUser = usersList.Find(x => x.Username == username);
    }
    else
    {
        return Results.BadRequest();
    }
    if (!specifiedUser.RefreshToken.Equals(refreshToken))
    {
        return Results.Json("Invalid Refresh Token.", statusCode: 401);
    }
    else if (specifiedUser.TokenExpires < DateTime.Now)
    {
        return Results.Json("Token Expired.", statusCode: 401);
    }
    string token = CreateToken(username);
    var newRefreshToken = GenerateRefreshToken();
    SetRefreshToken(newRefreshToken, token, specifiedUser, response);

    specifiedUser.RefreshToken = newRefreshToken.Token.ToString();
    //await SaveUserToJson();

    List<string> tokens = new List<string>()
    {
        token,
        newRefreshToken.Token.ToString()
    };
    return Results.Ok(tokens);
});

//Get all recipes
app.MapGet("/recipes", [Authorize] () =>
{
    if (recipesList != null)
        return Results.Ok(recipesList);
    else
        return Results.NoContent();
}).WithName("GetRecipes");

//Get specific  recipe
app.MapGet("/recipe/{id}", [Authorize] (Guid id) =>
{
    var selectedRecipeIndex = recipesList.FindIndex(x => x.Id == id);
    if (selectedRecipeIndex != -1)
    {
        return Results.Ok(recipesList[selectedRecipeIndex]);
    }
    else
    {
        return Results.NotFound();
    }
});

//Add new recipe
app.MapPost("/recipe", [Authorize] async ([FromBody] Recipe newRecipe) =>
{
    recipesList.Add(newRecipe);
    //await SaveRecipeToJson();
    return Results.Ok(recipesList);
});

//Edit recipe
app.MapPut("/recipe/{id}", [Authorize] async (Guid id, [FromBody] Recipe newRecipeData) =>
{
    var selectedRecipeIndex = recipesList.FindIndex(x => x.Id == id);
    if (selectedRecipeIndex != -1)
    {
        recipesList[selectedRecipeIndex] = newRecipeData;
        //await SaveRecipeToJson();
        return Results.Ok(recipesList);
    }
    else
    {
        return Results.NotFound();
    }
});

//Remove recipe
app.MapDelete("/recipe/{id}", [Authorize] async (Guid id) =>
{
    var selectedRecipeIndex = recipesList.FindIndex(x => x.Id == id);
    if (selectedRecipeIndex != -1)
    {
        recipesList.Remove(recipesList[selectedRecipeIndex]);
        //await SaveRecipeToJson();
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

//Get all categories
app.MapGet("/categories", async () =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        var metaData = new LinqMetaData(adapter);
        var categoryList = await metaData.Category.Where(x => x.IsActive == true).OrderBy(x => x.CategoryName).ToListAsync();
        var categories = categoryList.Select(x => x.CategoryName).ToList();
        if (categoryList != null)
            return Results.Ok(categories);
        else
            return Results.NoContent();
    }
});

//Add category
app.MapPost("/category", async ([FromBody] string newCategory) =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        var metaData = new LinqMetaData(adapter);
        var categoryList = await metaData.Category.Where(x => x.IsActive == true).OrderBy(x => x.CategoryName).ToListAsync();
        var categories = categoryList.Select(x => x.CategoryName).ToList();
        if (!categories.Contains(newCategory) && newCategory != "")
        {
            categories.Add(newCategory);
            CategoryEntity newCategoryEntity = new CategoryEntity()
            {
                Id = Guid.NewGuid().ToString(),
                CategoryName = newCategory,
                IsActive = true
            };
            await adapter.SaveEntityAsync(newCategoryEntity);
            return Results.Ok(categories);
        }
        else
        {
            return Results.BadRequest();
        }
    }
});

//Edit category
app.MapPut("/category/{name}", async (string name, [FromBody] string newCategoryName) =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        var metaData = new LinqMetaData(adapter);
        var categoryList = await metaData.Category.Where(x => x.IsActive == true).OrderBy(x => x.CategoryName).ToListAsync();
        var categories = categoryList.Select(x => x.CategoryName).ToList();

        var selectedCategoryId = categoryList.FirstOrDefault(x => x.CategoryName == name)?.Id;

        int indexOfCategory = categories.FindIndex(x => x == name);
        if (selectedCategoryId != null && !categories.Contains(newCategoryName) && newCategoryName != "")
        {
            categories[indexOfCategory] = newCategoryName;

            CategoryEntity newCategoryEntity = new CategoryEntity()
            {
                Id = selectedCategoryId,
                CategoryName = newCategoryName,
                IsNew = false
            };

            await adapter.SaveEntityAsync(newCategoryEntity);


            return Results.Ok(categories);
        }
        else
        {
            return Results.BadRequest();
        }
    }
});

//Delete Category
app.MapDelete("category/{name}", async (string name) =>
{
    using (var adapter = new DataAccessAdapter(connectionString))
    {
        var metaData = new LinqMetaData(adapter);
        var categoryList = await metaData.Category.Where(x => x.IsActive == true).OrderBy(x => x.CategoryName).ToListAsync();
        var categories = categoryList.Select(x => x.CategoryName).ToList();
        var selectedCategory = categoryList.FirstOrDefault(x => x.CategoryName == name);

        if (categories.Contains(name) && selectedCategory != null)
        {
            CategoryEntity deletedCategoryEntity = new CategoryEntity()
            {
                Id = selectedCategory.Id,
                CategoryName = name,
                IsActive = false,
                IsNew = false
            };

            categories.Remove(name);

            var deletedRecipeCategoryList = new EntityCollection<RecipeCategoryEntity>();
            foreach (var deletedRecipeCategory in metaData.RecipeCategory.Where(x => x.IsActive == true && x.CategoryId == selectedCategory.Id))
            {
                deletedRecipeCategory.IsActive = false;
                deletedRecipeCategoryList.Add(deletedRecipeCategory);
            }

            await adapter.SaveEntityAsync(deletedCategoryEntity);
            await adapter.SaveEntityCollectionAsync(deletedRecipeCategoryList);

            return Results.Ok(categories);
        }
        else
        {
            return Results.NotFound();
        }
    }
});

app.Run();

string CreateToken(string userName)
{
    var key = Encoding.ASCII.GetBytes
        (builder.Configuration["Jwt:Key"]);
    var tokenDescriptor = new SecurityTokenDescriptor
    {
        Subject = new ClaimsIdentity(new[]
        {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString())
             }),
        Expires = DateTime.UtcNow.AddMinutes(30),
        SigningCredentials = new SigningCredentials
        (new SymmetricSecurityKey(key),
        SecurityAlgorithms.HmacSha512Signature)
    };
    var tokenHandler = new JwtSecurityTokenHandler();
    var token = tokenHandler.CreateToken(tokenDescriptor);
    var jwtToken = tokenHandler.WriteToken(token);
    var stringToken = tokenHandler.WriteToken(token);
    return stringToken;
}

RefreshToken GenerateRefreshToken()
{
    var refreshToken = new RefreshToken
    {
        Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
        Expires = DateTime.Now.AddDays(7),
        Created = DateTime.Now
    };
    return refreshToken;
}

void SetRefreshToken(RefreshToken newRefreshToken, string accessToken, User loggedUser, Microsoft.AspNetCore.Http.HttpResponse response)
{
    var cookieOptions = new CookieOptions
    {
        HttpOnly = true,
        Expires = newRefreshToken.Expires
    };

    response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);
    response.Cookies.Append("accessToken", accessToken, cookieOptions);
    loggedUser.RefreshToken = newRefreshToken.Token;
    loggedUser.TokenCreated = newRefreshToken.Created;
    loggedUser.TokenExpires = newRefreshToken.Expires;
}

void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
{
    using (var hmac = new HMACSHA512())
    {
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
    }
}

bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
{
    using (var hmac = new HMACSHA512(passwordSalt))
    {
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(passwordHash);
    }
}

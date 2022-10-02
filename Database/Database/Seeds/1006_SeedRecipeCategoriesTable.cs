using FluentMigrator;

namespace Database.Seeds
{
    [Migration(12)]
    public class SeedRecipeCategoriesTable : Migration
    {
        public List<(string, string)> SeedRecipeCategories = new List<(string, string)>
        {
            ("1","1"),
            ("1","2"),
            ("1","2"),
            ("2","2"),

        };
        public override void Up()
        {
            foreach (var seedRecipeCategory in SeedRecipeCategories)
            {
                Insert.IntoTable("RecipeCategories").Row(new
                {
                    id = Guid.NewGuid().ToString(),
                    recipe_id = seedRecipeCategory.Item1,
                    category_id = seedRecipeCategory.Item2,
                    is_active = true
                });
            }
        }

        public override void Down() { }
    }
}

using FluentMigrator;

namespace Database.Seeds
{
    [Migration(10)]
    public class _1004_SeedRecipeIngredientsTable:Migration
    {
        public List<(string, string)> SeedRecipeIngredients = new List<(string, string)>
        {
            ("1","sugar"),
            ("1","hot water"),
            ("1","tea packet"),
            ("2"," cocoa"),
            ("2", "water")
        };

        public override void Up()
        {
            foreach (var seedRecipeIngredient in SeedRecipeIngredients)
            {
                Insert.IntoTable("RecipeIngredients").Row(new
                {
                    id = Guid.NewGuid().ToString(),
                    recipe_id = seedRecipeIngredient.Item1,
                    ingredient = seedRecipeIngredient.Item2,
                    is_active = true
                });
            }
        }

        public override void Down() { }
    }
}

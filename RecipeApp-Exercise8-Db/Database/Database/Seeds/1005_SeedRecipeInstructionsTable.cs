using FluentMigrator;

namespace Database.Seeds
{
    [Migration(11)]
    public class _1005_SeedRecipeInstructionsTable:Migration
    {
        public List<(string, string)> SeedRecipeInstructions = new List<(string, string)>
        {
            ("1","Add tea packet"),
            ("1","Add sugar"),
            ("1","Add hot water"),
            ("2","Add hot cocoa"),
            ("2", "Add hot water")
        };

        public override void Up()
        {
            foreach(var seedRecipeInstruction in SeedRecipeInstructions)
            {
                Insert.IntoTable("RecipeInstructions").Row(new
                {
                    id = Guid.NewGuid().ToString(),
                    recipe_id = seedRecipeInstruction.Item1,
                    instruction= seedRecipeInstruction.Item2,
                    is_active = true
                });
            }
        }

        public override void Down() { }
    }
}

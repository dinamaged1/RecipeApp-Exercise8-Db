using FluentMigrator;

namespace Database.Seeds
{
    [Migration(9)]
    public class _1003_SeedRecipeTable : Migration
    {
        public List<string> SeedRecipes = new List<string> { "Hot tea", "Hot cocoa" };
        public override void Up()
        {
            for(int i = 1; i < SeedRecipes.Count+1; i++)
            {
                Insert.IntoTable("Recipe").Row(new
                {
                    id = i.ToString(),
                    title = SeedRecipes[i - 1],
                    image_path=i.ToString(),
                    is_active=true
                }); ;
            }
        }
        public override void Down() { }
    }
}

using FluentMigrator;

namespace Database.Seeds
{
    [Migration(8)]
    public class _1002_SeedCategoryTable: Migration
    {
        public List<string> SeedCategories { get; set; } = new List<string> { "Egyptian food", "Desserts", "Hot drinks" };

        public override void Up()
        {
            int i = 0;
            foreach (var category in SeedCategories)
            {
                i++;
                Insert.IntoTable("Category").Row(new
                {
                    id = i.ToString(),
                    category_name = category,
                    is_active = true
                }); 
            }

        }
        public override void Down()
        {

        }
    }
}

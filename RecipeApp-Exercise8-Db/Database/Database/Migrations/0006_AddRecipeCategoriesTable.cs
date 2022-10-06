using System;
using FluentMigrator;

namespace Database.Migrations
{
    [Migration(6)]
    public class _0006_AddRecipeCategoriesTable: Migration
    {
        public override void Up()
        {
            Create.Table("RecipeCategories")
                    .WithColumn("id").AsString().PrimaryKey()
                    .WithColumn("recipe_id").AsString().NotNullable().ForeignKey("Recipe", "id").OnDelete(System.Data.Rule.Cascade)
                    .WithColumn("category_id").AsString().NotNullable().ForeignKey("Category","id").OnDelete(System.Data.Rule.Cascade)
                    .WithColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table("RecipeCategories");
        }
    }
}

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
                    .WithColumn("id").AsGuid().PrimaryKey()
                    .WithColumn("recipe_id").AsGuid().NotNullable().ForeignKey("Recipe", "id")
                    .WithColumn("category").AsString(1000).NotNullable()
                    .WithColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table("RecipeCategories");
        }
    }
}

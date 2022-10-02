using System;
using FluentMigrator;

namespace Database.Migrations
{
    [Migration(4)]
    public class _0004_AddRecipeIngredientsTable: Migration
    {
        public override void Up()
        {
            Create.Table("RecipeIngredients")
                    .WithColumn("id").AsString().PrimaryKey()
                    .WithColumn("recipe_id").AsString().NotNullable().ForeignKey("Recipe", "id")
                    .WithColumn("ingredient").AsString(1000).NotNullable()
                    .WithColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table("RecipeIngredients");
        }
    }
}

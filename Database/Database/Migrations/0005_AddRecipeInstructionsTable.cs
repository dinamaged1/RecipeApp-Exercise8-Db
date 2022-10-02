using System;
using FluentMigrator;

namespace Database.Migrations
{
    [Migration(5)]
    public class _0005_AddRecipeInstructionsTable: Migration
    {
        public override void Up()
        {
            Create.Table("RecipeInstructions")
                    .WithColumn("id").AsString().PrimaryKey()
                    .WithColumn("recipe_id").AsString().NotNullable().ForeignKey("Recipe", "id")
                    .WithColumn("instruction").AsString(1000).NotNullable()
                    .WithColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table("RecipeInstructions");
        }
    }
}

using System;
using FluentMigrator;

namespace Database.Migrations
{
    [Migration(2)]
    public class _0002_AddCategoryTable : Migration
    {
        public override void Up()
        {
            Create.Table("Category")
                .WithColumn("id").AsString().PrimaryKey()
                .WithColumn("category_name").AsString()
                .WithColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table("Category");
        }
    }
}

using System;
using FluentMigrator;

namespace Database.Migrations
{
    [Migration(1)]
    public class _0001_AddUserTable : Migration
    {
        public override void Up()
        {
            Create.Table("User")
                .WithColumn("id").AsString().PrimaryKey()
                .WithColumn("username").AsString()
                .WithColumn("password_hash").AsString()
                .WithColumn("password_salt").AsString()
                .WithColumn("refresh_token").AsString().Nullable()
                .WithColumn("token_created").AsDateTime().Nullable()
                .WithColumn("token_expires").AsDateTime().Nullable()
                .WithColumn("is_active").AsBoolean().NotNullable().WithDefaultValue(true);
        }

        public override void Down()
        {
            Delete.Table("User");
        }
    }
}

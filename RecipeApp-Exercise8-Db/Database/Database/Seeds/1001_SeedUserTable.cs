using FluentMigrator;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace Database.Seeds
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime? TokenCreated { get; set; }
        public DateTime? TokenExpires { get; set; }

        public User()
        {
        }

        public User(string userName, string passwordHash, string passwordSalt)
        {
            Id = Guid.NewGuid().ToString();
            Username=userName;
            PasswordHash=passwordHash;
            PasswordSalt=passwordSalt;
            RefreshToken = "";
            TokenCreated = null;
            TokenExpires = null;
        }
    }

    [Migration(7)]
    public class CreateUserSeedData : Migration
    {
        public static PasswordHasher<User> hasher = new();
        public List<User> Users { get; set; } = new List<User>
        {
            new User ("dina", hasher.HashPassword(new User(), "123456"), RandomNumberGenerator.GetBytes(128 / 8).ToString()!),
            new User ("layla", hasher.HashPassword(new User(), "12345678"), RandomNumberGenerator.GetBytes(128 / 8).ToString()!)
        };
        public override void Up()
        {
            foreach(var user in Users)
            {
                Insert.IntoTable("User").Row(new
                {
                    id=user.Id,
                    username=user.Username,
                    password_hash=user.PasswordHash,
                    password_salt=user.PasswordSalt,
                });
            }

        }
        public override void Down()
        {

        }
    }
}

using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Infra.Data.Context;
using System.Linq;
using BCrypt.Net;

namespace CleanArchMvc.Infra.Data.Seed
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    Username = "admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("123456"),
                    Role = "admin"
                });

                context.SaveChanges();
            }
        }
    }
}
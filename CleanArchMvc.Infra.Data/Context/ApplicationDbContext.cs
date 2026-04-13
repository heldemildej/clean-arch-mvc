using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CleanArchMvc.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }

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
}
using System;
using Microsoft.EntityFrameworkCore;

namespace OOPLab13._1.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public UserContext(DbContextOptions<UserContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            string adminLogin = "admin";
            string userLogin = "user";

            string adminEmail = "admin@gmail.com";
            string adminPassword = "admin1788";

            // добавляем роли
            Role adminRole = new Role { Id = 1, Login = adminLogin };
            Role userRole = new Role { Id = 2, Login = userLogin };
            User adminUser = new User { Id = 1, Login = adminRole.Login, Email=adminEmail, Password = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("UUser");
            modelBuilder.Entity<Comment>().ToTable("CComments");
        }
    }
}

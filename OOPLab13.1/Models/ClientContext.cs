using System;
using Microsoft.EntityFrameworkCore;
namespace OOPLab13._1.Models
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public ClientContext(DbContextOptions<ClientContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("CClient");
        }

    }
}

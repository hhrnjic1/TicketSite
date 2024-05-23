using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineProdajaKarata.Models;

namespace OnlineProdajaKarata.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Manifestacija> Manifestacija { get; set; }
        public DbSet<KupljenaMjesta> KupljenaMjesta{get; set;}
        public DbSet<Karta> Karta { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Manifestacija>().ToTable("Manifestacija");
            modelBuilder.Entity<KupljenaMjesta>().ToTable("KupljenaMjesta");
            modelBuilder.Entity<Karta>().ToTable("Karta");
            base.OnModelCreating(modelBuilder);
        }
    }
}

using FotoWebApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FotoWebApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Photographer> Photographers { get; set; }


        //// OnModelCreating method is used to configure the database schema and relationships between entities using Fluent API/syntax.
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    // Explicit config of the one-to-one relationship between ApplicationUser and Photographer
        //    builder.Entity<ApplicationUser>()
        //        .HasOne(a => a.Photographer)
        //        .WithOne(p => p.ApplicationUser)
        //        .HasForeignKey<Photographer>(p => p.UserId);
        //}
    }
}

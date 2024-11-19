using FotoWebApp.Models;
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

    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrionExpress.Models;

namespace OrionExpress.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;

using Taht.Core;

namespace Taht.Infrastructure
{
    public partial class DatabaseContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
            ApplyConfigurations(modelBuilder);
        }
    }
}
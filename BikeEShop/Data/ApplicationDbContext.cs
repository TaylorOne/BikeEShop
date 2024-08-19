using BikeEShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BikeEShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>()
                .HasMany(e => e.Colors)
                .WithMany(e => e.Bikes)
                .UsingEntity<BikeColor>();

            modelBuilder.Entity<Bike>()
                .HasMany(e => e.Sizes)
                .WithMany(e => e.Bikes)
                .UsingEntity<BikeSize>();

            modelBuilder.Entity<Inventory>()
                .HasOne(e => e.BikeSize)
                .WithMany(e => e.Inventory)
                .HasForeignKey(e => new { e.BikesId, e.SizesId })
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Inventory>()
                .HasOne(e => e.BikeColor)
                .WithMany(e => e.Inventory)
                .HasForeignKey(e => new { e.BikesId, e.ColorsId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<BikeColor> BikeColor { get; set; }
        public DbSet<BikeSize> BikeSize { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
    }
}

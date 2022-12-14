using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;
using YachtWorld.Infrastructure.Data.Configuration;

namespace YachtWorld.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Yacht>()
            .HasOne(s => s.Shipyard)
            .WithMany(y => y.Yachts)
            .HasForeignKey(s => s.ShipyardId);

            builder.Entity<Yacht>()
            .HasOne(s => s.Category)
            .WithMany(y => y.Yachts)
            .HasForeignKey(s => s.CategoryId);
            
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new YachtBrokerConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new YachtConfiguration());
            builder.ApplyConfiguration(new ShipyardConfiguration());
            builder.ApplyConfiguration(new DestinationConfiguration());


            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Destination> Destinations { get; set; } = null!;

        public DbSet<Shipyard> Shipyards { get; set; } = null!;

        public DbSet<Yacht> Yachts { get; set; } = null!;

        public DbSet<YachtBroker> YachtBrokers { get; set; } = null!;

    }
}
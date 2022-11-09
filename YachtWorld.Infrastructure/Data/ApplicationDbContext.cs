using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using YachtWorld.Infrastructure.Data.Configuration;

namespace YachtWorld.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                           ;
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new YachtBrokerConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new YachtConfiguration());
            builder.ApplyConfiguration(new ShipyardConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Destination> Destinations { get; set; } = null!;

        public DbSet<Shipyard> Shipyards { get; set; } = null!;

        public DbSet<Yacht> Yachts { get; set; } = null!;

        public DbSet<YachtBroker> YachtBrokers { get; set; } = null!;

    }
}
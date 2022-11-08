using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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


            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Shipyard> Shipyards { get; set; }

        public DbSet<Yacht> Yachts { get; set; }

        public DbSet<YachtBroker> YachtBrokers { get; set; }




    }
}
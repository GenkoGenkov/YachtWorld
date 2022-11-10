using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    internal class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.HasData(CreateDestinations());
        }

        private List<Destination> CreateDestinations()
        {
            List<Destination> destinations = new List<Destination>()
            {
                new Destination()
                {
                    Id = 1,
                    Name = "Mediterannean",
                    MainAttraction = "Cannes Film Festival"
                },

                new Destination()
                {
                    Id = 2,
                    Name = "Caribbean",
                    MainAttraction = "Tropical Climate"
                },

                new Destination()
                {
                    Id = 3,
                    Name = "Australasia",
                    MainAttraction = "Swim by a Waterfall"
                },

                new Destination()
                {
                    Id = 4,
                    Name = "Northern Europe",
                    MainAttraction = "Northern Lights"
                },

                new Destination()
                {
                    Id = 5,
                    Name = "South Pacific",
                    MainAttraction = "Flourishing Nature"
                },
            };

            return destinations;
        }
    }
}

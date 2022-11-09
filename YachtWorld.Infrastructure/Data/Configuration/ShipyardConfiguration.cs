using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    internal class ShipyardConfiguration : IEntityTypeConfiguration<Shipyard>
    {
        public void Configure(EntityTypeBuilder<Shipyard> builder)
        {
            builder.HasData(CreateShipyards());
        }

        private List<Shipyard> CreateShipyards()
        {
            List<Shipyard> shipyards = new List<Shipyard>()
            {
                new Shipyard()
                {
                    Id = 1,
                    Name = "Alloy Yachts",
                    Location = "New Zealand",
                    EstablishedIn = 1980
                },

                new Shipyard()
                {
                    Id = 2,
                    Name = "Amels Yachts",
                    Location = "Germany",
                    EstablishedIn = 1918
                },

                new Shipyard()
                {
                    Id = 3,
                    Name = "Azimut Yachts",
                    Location = "Italy",
                    EstablishedIn = 1969
                },

                new Shipyard()
                {
                    Id = 4,
                    Name = "Baglietto",
                    Location = "Port of Genova",
                    EstablishedIn = 1854
                },

                new Shipyard()
                {
                    Id = 5,
                    Name = "Benetti Yachts",
                    Location = "Italy",
                    EstablishedIn = 1873
                },

                new Shipyard()
                {
                    Id = 6,
                    Name = "Burger",
                    Location = "USA",
                    EstablishedIn = 1863
                },

                new Shipyard()
                {
                    Id = 7,
                    Name = "Cristensen Yachts",
                    Location = "Vancouver Washington",
                    EstablishedIn = null
                },

                new Shipyard()
                {
                    Id = 8,
                    Name = "Codecasa Yachts",
                    Location = "Italy",
                    EstablishedIn = 1825
                },

                new Shipyard()
                {
                    Id = 9,
                    Name = "Hakvoort Yachts",
                    Location = "Holland",
                    EstablishedIn = 1919
                },

                new Shipyard()
                {
                    Id = 10,
                    Name = "Inace",
                    Location = "Brazil",
                    EstablishedIn = 1960
                },
            };

            return shipyards;
        }
    }
}

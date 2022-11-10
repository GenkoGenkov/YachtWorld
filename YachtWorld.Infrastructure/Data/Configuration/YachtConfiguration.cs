﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    internal class YachtConfiguration : IEntityTypeConfiguration<Yacht>
    {
        public void Configure(EntityTypeBuilder<Yacht> builder)
        {
            builder.HasData(CreateYachts());
        }

        private List<Yacht> CreateYachts()
        {
            var yachts = new List<Yacht>()
            {
                new Yacht()
                {
                    Id = 1,
                    Title = "Frodo",
                    Description = "Delivered in 2020 and one of the finest jewels delivered\r\nby Benetti, 107m / 351' Frodo is a charter yacht of\r\nchoice in the 100m+/300'+ range. Built and designed by\r\nBenetti to discover every corner of the world, her striking\r\nlines are matched with an unrivaled level of luxury on all\r\ndecks.\r\nPowered by an unusual Rolls-Royce hybrid-electric\r\npropulsion, Frodo ensures wonderful fuel efficiency and a\r\nlong cruising range, making her eco-friendly with a\r\ncruising speed of 16 knots, and 18.5 knots top speed.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.jpg",
                    PriceForRent = 1_800_000.00M,
                    Guests = 12,
                    StateRooms = 8,
                    CrewMembers = 33,
                    Length = "107 Metres",
                    Engines = null,
                    Generators = "3 X Caterpillar",
                    MaxSpeed = "18.5 Knots",
                    CategoryId = 1,
                    YachtBrokerId = 1,
                    SailorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    ShipyardId = 1,
                }
            };

            return yachts;
        }
    }
}
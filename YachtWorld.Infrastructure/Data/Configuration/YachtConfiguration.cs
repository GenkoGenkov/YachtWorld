using Microsoft.EntityFrameworkCore;
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
                    Description = "Delivered in 2020 and one of the finest jewels delivered by Benetti, 107m / 351' Frodo is a charter yacht of choice in the 100m+/300'+ range. Built and designed by Benetti to discover every corner of the world, her striking lines are matched with an unrivaled level of luxury on all decks. Powered by an unusual Rolls-Royce hybrid-electric propulsion, Frodo ensures wonderful fuel efficiency and a long cruising range, making her eco-friendly with a cruising speed of 16 knots, and 18.5 knots top speed.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.png",
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
                },

                new Yacht()
                {
                    Id = 2,
                    Title = "Aragorn",
                    Description = "Aragorn is one of the world's largest and most impressive charter yachts, ideal for entertaining on a grand scale. She boasts many special features including a spa, a gym, a cinema and vast deck spaces. Her interior is opulent and grand and she features not one but two Jacuzzis. Accommodating 36 guests in eighteen staterooms she offers a large group or several small groups the chance for the experience of a lifetime on the West Mediterranean.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Aragorn.png",
                    PriceForRent = 645_000.00M,
                    Guests = 36,
                    StateRooms = 18,
                    CrewMembers = 36,
                    Length = "91.4 Metres",
                    Engines = "2 X Caterpillar",
                    Generators = "3 X Caterpillar",
                    MaxSpeed = "15 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 2,
                },

                new Yacht()
                {
                    Id = 3,
                    Title = "Samwise",
                    Description = "One of the world’s fastest explorer yachts at 23 knots, Samwise combines adventure yacht capabilities with a superyacht finish. Featuring a helideck suitable for an AW109 or similar, plus a crane with 15M (49’) reach ideal for launching the array of tenders and toys on board, she offers unlimited possibilities.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Samwise.png",
                    PriceForRent = 1_000_000.00M,
                    Guests = 12,
                    StateRooms = 8,
                    CrewMembers = 34,
                    Length = "85.1 Metres",
                    Engines = "2 X Caterpillar",
                    Generators = "3 X Caterpillar",
                    MaxSpeed = "17.5 Knots",
                    CategoryId = 3,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 7,
                },

                new Yacht()
                {
                    Id = 4,
                    Title = "Meriadoc",
                    Description = "Meriadoc is a multi-award-winning, feature-packed explorer yacht equipped to provide the ultimate charter experience. The 85-metre superyacht for charter offers the best of both worlds, made to entertain and explore the beauty the world has to offer. Delivered by AKYACHT in Summer 2021, she brings together Michael Leach Design and H2 Yacht Design.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Meriadoc.png",
                    PriceForRent = 934_700.00M,
                    Guests = 12,
                    StateRooms = 6,
                    CrewMembers = 26,
                    Length = "85.1 Metres",
                    Engines = "2 X Caterpillar",
                    Generators = "4 X Caterpillar",
                    MaxSpeed = "16 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 5,
                },

                new Yacht()
                {
                    Id = 5,
                    Title = "Peregrin",
                    Description = "Peregrin was built for pure fun and adventure. With a 7,640 nautical mile range and equipped with all the latest toys, she offers pure unadulterated adventure, thrills and fun with all the luxuries you would come to expect of a superyacht from world-class cuisine to a dedicated spa centre, all whilst cruising the world’s remotest oceans. Not for charter to US residents while in US waters.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Peregrin.png",
                    PriceForRent = 604_700.00M,
                    Guests = 28,
                    StateRooms = 11,
                    CrewMembers = 28,
                    Length = "77.4 Metres",
                    Engines = "2 X Smit-Man",
                    Generators = "3 X John Deere",
                    MaxSpeed = "12 Knots",
                    CategoryId = 1,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 9,
                },

                new Yacht()
                {
                    Id = 6,
                    Title = "Legolas",
                    Description = "Enhance your Legolas experience: watch here the Chief Stewardess preparing the yacht's cocktail signature HOT WHEELS, and join the Captain here for a complete walkthrough. A certified family-friendly motor yacht for charter, 76m/249’ Legolas is undoubtedly one of the most acclaimed vessels in her range. Seven decks of outstanding features are spread over a volume of nearly 2,000GT . Legolas is operated by an Owner who has been meticulous in her maintenance and upgrades.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Legolas.png",
                    PriceForRent = 836_300.00M,
                    Guests = 12,
                    StateRooms = 6,
                    CrewMembers = 21,
                    Length = "75.5 Metres",
                    Engines = "2 X MTU",
                    Generators = "3 X Caterpillar",
                    MaxSpeed = "18 Knots",
                    CategoryId = 4,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 4,
                },

                new Yacht()
                {
                    Id = 7,
                    Title = "Gimli",
                    Description = "Having undergone an interior refit in 2018, 73M Lurssen yacht for charter Gimli is everything you would expect from such a renowned shipyard and more. Boasting magnificent spaces both inside and out she offers all the features of luxury life on a superyacht, including huge entertainment spaces, the very latest amenities and incredible accommodation.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Gimli.png",
                    PriceForRent = 585_400.00M,
                    Guests = 12,
                    StateRooms = 7,
                    CrewMembers = 19,
                    Length = "73 Metres",
                    Engines = "2 X Caterpillar",
                    Generators = "2 X Caterpillar",
                    MaxSpeed = "16 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 10,
                },

                new Yacht()
                {
                    Id = 8,
                    Title = "Smeagol",
                    Description = "Smeagol is a recently refit 72M superyacht available for charter in the Mediterranean, the Balearics, Croatia, the Arabian Gulf, Indian Ocean and the Red Sea. She accommodates up to 28 guests in14 staterooms and boasts special features such as a Jacuzzi. Her spacious decks provide the ideal situation for relaxing with friends or family and taking in the scenery of the surrounding area.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Smeagol.png",
                    PriceForRent = 559_000.00M,
                    Guests = 30,
                    StateRooms = 16,
                    CrewMembers = 30,
                    Length = "72 Metres",
                    Engines = "2 X MTU",
                    Generators = "3 X MAN",
                    MaxSpeed = "16.2 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 3,
                },

                new Yacht()
                {
                    Id = 9,
                    Title = "Boromir",
                    Description = "Boromir offers the ultimate charter experience. She accommodates up to 26 guests in 13 beautiful staterooms, features a spa on board, in addition to a plethora of toys. Her luxurious interior décor and incredible facilities create the ideal charter yacht for large families or corporate events. Not for charter to US residents while in US waters.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Boromir.png",
                    PriceForRent = 492_900.00M,
                    Guests = 28,
                    StateRooms = 13,
                    CrewMembers = 19,
                    Length = "69.65 Metres",
                    Engines = "1 X Caterpillar",
                    Generators = "2 X John Deere",
                    MaxSpeed = "13 Knots",
                    CategoryId = 4,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 6,
                },

                new Yacht()
                {
                    Id = 10,
                    Title = "Gandalf",
                    Description = "Gandalf, the 54.3M Amels superyacht for charter, is a world cruiser designed for free spirits that harmoniously combines zen and adventure. She accommodates 11 guests in five staterooms and is available in the Caribbean and Central America. She boasts a contemporary interior and spacious decks, as well as an impressive range of water toys for guests' recreational enjoyment.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Gandalf.png",
                    PriceForRent = 299_900.00M,
                    Guests = 12,
                    StateRooms = 5,
                    CrewMembers = 13,
                    Length = "54.3 Metres",
                    Engines = "2 X MTU",
                    Generators = "3 X Northern Lights",
                    MaxSpeed = "15.5 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 8,
                },

                new Yacht()
                {
                    Id = 11,
                    Title = "Saruman",
                    Description = "With her traditional lines and Feadship pedigree Saruman epitomises classic superyacht charm, yet delve a little deeper  and you find interiors and amenities at the highest levels of modern luxury. Saruman is committed to lowering its impact on the environment by making a conscious effort to reduce  its carbon footprint.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Saruman.png",
                    PriceForRent = 203_300.00M,
                    Guests = 12,
                    StateRooms = 8,
                    CrewMembers = 14,
                    Length = "53.1 Metres",
                    Engines = "2 X Caterpillar",
                    Generators = "2 X Northern Lights",
                    MaxSpeed = "16 Knots",
                    CategoryId = 1,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 9,
                },

                new Yacht()
                {
                    Id = 12,
                    Title = "Sauron",
                    Description = "Sauron is a beautiful 52m yacht for charter with accommodation for 12 guests in six comfortable staterooms. Spacious and classic in style, Sauron boasts a hot tub, sports bar, vast alfresco dining area and an abundant array of water toys. Her large party deck is ideal for entertaining.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Sauron.png",
                    PriceForRent = 172_100.00M,
                    Guests = 12,
                    StateRooms = 6,
                    CrewMembers = 10,
                    Length = "52.4 Metres",
                    Engines = "2 X Cummins",
                    Generators = "3 X Northern Lights",
                    MaxSpeed = "15 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 7,
                },

                new Yacht()
                {
                    Id = 13,
                    Title = "Smaug",
                    Description = "Smaug is a highly pedigreed yacht, blending modern and classic styles.  Accommodations include five spacious staterooms with three staterooms with king beds and two staterooms with queen beds.  Two of the kings convert to twin beds with two Pullman berths in each of these staterooms. Additional amenities include a wide assortment of water toys, exercise equipment, large tender, shade for alfresco dining, multiple areas for sunbathing and a Jacuzzi.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Smaug.png",
                    PriceForRent = 249_100.00M,
                    Guests = 12,
                    StateRooms = 5,
                    CrewMembers = 11,
                    Length = "51.1 Metres",
                    Engines = "2 X Caterpillar",
                    Generators = "2 X Northern Lights",
                    MaxSpeed = "15 Knots",
                    CategoryId = 2,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 3,
                },

                new Yacht()
                {
                    Id = 14,
                    Title = "Theoden",
                    Description = "Theoden is the ultimate platform for adventures and exploration around the stunning, remote waters of Indonesia and Asia. A traditional Indonesian Phinisi design launched in 2014, she offers stable and comfortable cruising with no compromise to luxury. Sleeping up to 14 guests in seven spacious and well-appointed staterooms, she features spacious outdoor decks for large groups of friends and families to enjoy while taking in the view.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Theoden.png",
                    PriceForRent = 120_000.00M,
                    Guests = 50,
                    StateRooms = 7,
                    CrewMembers = 18,
                    Length = "51 Metres",
                    Engines = "1 X Yanmar",
                    Generators = "2 X Northern Lights",
                    MaxSpeed = "12 Knots",
                    CategoryId = 1,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 1,
                },

                new Yacht()
                {
                    Id = 15,
                    Title = "Elrond",
                    Description = "Highly custom designed, with an unmissable metallic blue hull and a sleek silhouette inspired by a modern jet fighter, Elrond combines stunning spaces with the latest technology and boasts a top speed of 25 knots. Featuring a striking open-plan contemporary interior and an award winning exterior, she is ideal for entertaining.",
                    ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Elrond.png",
                    PriceForRent = 284_600.00M,
                    Guests = 12,
                    StateRooms = 8,
                    CrewMembers = 14,
                    Length = "51 Metres",
                    Engines = "2 X MTU",
                    Generators = null,
                    MaxSpeed = "25 Knots",
                    CategoryId = 1,
                    YachtBrokerId = 1,
                    SailorId = null,
                    ShipyardId = 10,
                },
            };

            return yachts;
        }
    }
}

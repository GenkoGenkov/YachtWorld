using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace YachtWorld.Infrastructure.Data.Configuration
{
    internal class YachtConfiguration : IEntityTypeConfiguration<Yacht>
    {
        public void Configure(EntityTypeBuilder<Yacht> builder)
        {
            //builder.HasData(CreateYachts());
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
                    ImageUrl = "https://dynaimage.cdn.cnn.com/cnn/q_auto,w_1100,c_fill,g_auto,h_619,ar_16:9/http%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F210701131326-worlds-largest-yacht--credit--winch-design-3.jpg",
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
                    DestinationId = 1
                },

                new Yacht()
                {
                    Id = 2,
                    Title = "Aragorn",
                    Description = "Aragorn is one of the world's largest and most impressive charter yachts, ideal for entertaining on a grand scale. She boasts many special features including a spa, a gym, a cinema and vast deck spaces. Her interior is opulent and grand and she features not one but two Jacuzzis. Accommodating 36 guests in eighteen staterooms she offers a large group or several small groups the chance for the experience of a lifetime on the West Mediterranean.",
                    ImageUrl = "https://media.cntraveler.com/photos/633465b708c8c4ac97ede225/master/pass/four%20seasons%20yacht-sept22-pr4.jpg",
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
                    DestinationId = 2
                },

                new Yacht()
                {
                    Id = 3,
                    Title = "Samwise",
                    Description = "One of the world’s fastest explorer yachts at 23 knots, Samwise combines adventure yacht capabilities with a superyacht finish. Featuring a helideck suitable for an AW109 or similar, plus a crane with 15M (49’) reach ideal for launching the array of tenders and toys on board, she offers unlimited possibilities.",
                    ImageUrl = "https://moranyachts.imgix.net/wp-content/uploads/Luxury-yacht-Lurssen-Marguertie-for-charter-0402.jpg?auto=format&fit=crop&fm=webp%26nbsp%3B2x&h=320&ixlib=php-3.1.0&w=535&s=98ca6fe304806a46cea19caac252926c",
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
                    DestinationId = 3
                },

                new Yacht()
                {
                    Id = 4,
                    Title = "Meriadoc",
                    Description = "Meriadoc is a multi-award-winning, feature-packed explorer yacht equipped to provide the ultimate charter experience. The 85-metre superyacht for charter offers the best of both worlds, made to entertain and explore the beauty the world has to offer. Delivered by AKYACHT in Summer 2021, she brings together Michael Leach Design and H2 Yacht Design.",
                    ImageUrl = "https://yachtharbour.com/static/uploads/scale_1240_d3197.jpg",
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
                    DestinationId = 4
                },

                new Yacht()
                {
                    Id = 5,
                    Title = "Peregrin",
                    Description = "Peregrin was built for pure fun and adventure. With a 7,640 nautical mile range and equipped with all the latest toys, she offers pure unadulterated adventure, thrills and fun with all the luxuries you would come to expect of a superyacht from world-class cuisine to a dedicated spa centre, all whilst cruising the world’s remotest oceans. Not for charter to US residents while in US waters.",
                    ImageUrl = "https://media.fraseryachts.com/Yachts/Y46_MC_MC/images/website/Benetti_yacht_for_charter_Formosa_22555-nHJHhqpS.jpg?vh=d79e30",
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
                    DestinationId = 5
                },

                new Yacht()
                {
                    Id = 6,
                    Title = "Legolas",
                    Description = "Enhance your Legolas experience: watch here the Chief Stewardess preparing the yacht's cocktail signature HOT WHEELS, and join the Captain here for a complete walkthrough. A certified family-friendly motor yacht for charter, 76m/249’ Legolas is undoubtedly one of the most acclaimed vessels in her range. Seven decks of outstanding features are spread over a volume of nearly 2,000GT . Legolas is operated by an Owner who has been meticulous in her maintenance and upgrades.",
                    ImageUrl = "https://www.wartsila.com/images/default-source/marine-pictures/yachts/super-intelligent-yachts.jpg?sfvrsn=355a4043_3",
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
                    DestinationId = 1
                },

                new Yacht()
                {
                    Id = 7,
                    Title = "Gimli",
                    Description = "Having undergone an interior refit in 2018, 73M Lurssen yacht for charter Gimli is everything you would expect from such a renowned shipyard and more. Boasting magnificent spaces both inside and out she offers all the features of luxury life on a superyacht, including huge entertainment spaces, the very latest amenities and incredible accommodation.",
                    ImageUrl = "https://yachtharbour.com/static/uploads/scale_1240_0e8d9.jpg",
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
                    DestinationId = 2
                },

                new Yacht()
                {
                    Id = 8,
                    Title = "Smeagol",
                    Description = "Smeagol is a recently refit 72M superyacht available for charter in the Mediterranean, the Balearics, Croatia, the Arabian Gulf, Indian Ocean and the Red Sea. She accommodates up to 28 guests in14 staterooms and boasts special features such as a Jacuzzi. Her spacious decks provide the ideal situation for relaxing with friends or family and taking in the scenery of the surrounding area.",
                    ImageUrl = "http://cdn.cnn.com/cnnnext/dam/assets/211109221217-02-somnio-residential-superyacht.jpg",
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
                    DestinationId = 3
                },

                new Yacht()
                {
                    Id = 9,
                    Title = "Boromir",
                    Description = "Boromir offers the ultimate charter experience. She accommodates up to 26 guests in 13 beautiful staterooms, features a spa on board, in addition to a plethora of toys. Her luxurious interior décor and incredible facilities create the ideal charter yacht for large families or corporate events. Not for charter to US residents while in US waters.",
                    ImageUrl = "https://media.fraseryachts.com/Yachts/Y6063_MC_MC/images/website/Benetti_yacht_for_sale_Alfa_20603-wUutHQHe.jpg?vh=51ce02",
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
                    DestinationId = 4
                },

                new Yacht()
                {
                    Id = 10,
                    Title = "Gandalf",
                    Description = "Gandalf, the 54.3M Amels superyacht for charter, is a world cruiser designed for free spirits that harmoniously combines zen and adventure. She accommodates 11 guests in five staterooms and is available in the Caribbean and Central America. She boasts a contemporary interior and spacious decks, as well as an impressive range of water toys for guests' recreational enjoyment.",
                    ImageUrl = "https://nasco-yachts.com/wp-content/uploads/2021/09/Miami-Super-yacht-rental-at-sea.jpg",
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
                    DestinationId = 5
                },

                new Yacht()
                {
                    Id = 11,
                    Title = "Saruman",
                    Description = "With her traditional lines and Feadship pedigree Saruman epitomises classic superyacht charm, yet delve a little deeper  and you find interiors and amenities at the highest levels of modern luxury. Saruman is committed to lowering its impact on the environment by making a conscious effort to reduce  its carbon footprint.",
                    ImageUrl = "https://iycstorage.s3.amazonaws.com/import/wordpress/2015/09/Yacht_Impromptu_Superyacht_charter_profile.jpg",
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
                    DestinationId = 1
                },

                new Yacht()
                {
                    Id = 12,
                    Title = "Sauron",
                    Description = "Sauron is a beautiful 52m yacht for charter with accommodation for 12 guests in six comfortable staterooms. Spacious and classic in style, Sauron boasts a hot tub, sports bar, vast alfresco dining area and an abundant array of water toys. Her large party deck is ideal for entertaining.",
                    ImageUrl = "https://cdn.boatinternational.com/files/2020/12/7a18d620-3bcb-11eb-957a-6996e21593a4-top-25-nord-credit-Tom-Van-Oossanen.jpg",
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
                    DestinationId = 2
                },

                new Yacht()
                {
                    Id = 13,
                    Title = "Smaug",
                    Description = "Smaug is a highly pedigreed yacht, blending modern and classic styles.  Accommodations include five spacious staterooms with three staterooms with king beds and two staterooms with queen beds.  Two of the kings convert to twin beds with two Pullman berths in each of these staterooms. Additional amenities include a wide assortment of water toys, exercise equipment, large tender, shade for alfresco dining, multiple areas for sunbathing and a Jacuzzi.",
                    ImageUrl = "https://photo-assets.superyachttimes.com/photo/53338/image/large-c3d76ea97da2917a035084f5523f38b4.jpg",
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
                    DestinationId = 3
                },

                new Yacht()
                {
                    Id = 14,
                    Title = "Theoden",
                    Description = "Theoden is the ultimate platform for adventures and exploration around the stunning, remote waters of Indonesia and Asia. A traditional Indonesian Phinisi design launched in 2014, she offers stable and comfortable cruising with no compromise to luxury. Sleeping up to 14 guests in seven spacious and well-appointed staterooms, she features spacious outdoor decks for large groups of friends and families to enjoy while taking in the view.",
                    ImageUrl = "https://images.mansionglobal.com/im-361289?width=1280&size=1.77777778",
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
                    DestinationId = 4
                },

                new Yacht()
                {
                    Id = 15,
                    Title = "Elrond",
                    Description = "Highly custom designed, with an unmissable metallic blue hull and a sleek silhouette inspired by a modern jet fighter, Elrond combines stunning spaces with the latest technology and boasts a top speed of 25 knots. Featuring a striking open-plan contemporary interior and an award winning exterior, she is ideal for entertaining.",
                    ImageUrl = "https://cdn-bnkbk.nitrocdn.com/nAFpEbfLTzfNdwqrFBzzCzGgTRTvTBTC/assets/static/optimized/rev-88cb8a7/wp-content/uploads/2021/01/Yacht-Holiday-Indonesia-1.jpg",
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
                    DestinationId = 5
                },
            };

            return yachts;
        }
    }
}

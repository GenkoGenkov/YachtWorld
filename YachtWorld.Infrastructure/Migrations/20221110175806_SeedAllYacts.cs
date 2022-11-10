using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedAllYacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "073617bd-a054-4da1-b520-57558b62d9b6", "AQAAAAEAACcQAAAAEAfwkZuPPAeXiUZcIz6deq8+zdo2YI2/tftBzN6/msHtfawo7swT3Hxe4hVKFxneGg==", "8ed9b7e6-a65c-403c-8737-a0c9695a4c59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16624ae8-76b3-4dc3-bd36-2df3ac986d4b", "AQAAAAEAACcQAAAAECyvx/QTRIV1PL+lYu65s7ZSKCUAtMUR12DOeI7uxqgIT+cAEurGWzOnecKxJw6Y7A==", "c8e58b79-d74b-441f-bebe-9f81e8c000f1" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Delivered in 2020 and one of the finest jewels delivered by Benetti, 107m / 351' Frodo is a charter yacht of choice in the 100m+/300'+ range. Built and designed by Benetti to discover every corner of the world, her striking lines are matched with an unrivaled level of luxury on all decks. Powered by an unusual Rolls-Royce hybrid-electric propulsion, Frodo ensures wonderful fuel efficiency and a long cruising range, making her eco-friendly with a cruising speed of 16 knots, and 18.5 knots top speed.");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Aragorn is one of the world's largest and most impressive charter yachts, ideal for entertaining on a grand scale. She boasts many special features including a spa, a gym, a cinema and vast deck spaces. Her interior is opulent and grand and she features not one but two Jacuzzis. Accommodating 36 guests in eighteen staterooms she offers a large group or several small groups the chance for the experience of a lifetime on the West Mediterranean.");

            migrationBuilder.InsertData(
                table: "Yachts",
                columns: new[] { "Id", "CategoryId", "CrewMembers", "Description", "Engines", "Generators", "Guests", "ImageUrl", "Length", "MaxSpeed", "PriceForRent", "SailorId", "ShipyardId", "StateRooms", "Title", "YachtBrokerId" },
                values: new object[,]
                {
                    { 3, 3, 34, "One of the world’s fastest explorer yachts at 23 knots, Samwise combines adventure yacht capabilities with a superyacht finish. Featuring a helideck suitable for an AW109 or similar, plus a crane with 15M (49’) reach ideal for launching the array of tenders and toys on board, she offers unlimited possibilities.", "2 X Caterpillar", "3 X Caterpillar", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Samwise.png", "85.1 Metres", "17.5 Knots", 1000000.00m, null, 7, 8, "Samwise", 1 },
                    { 4, 2, 26, "Meriadoc is a multi-award-winning, feature-packed explorer yacht equipped to provide the ultimate charter experience. The 85-metre superyacht for charter offers the best of both worlds, made to entertain and explore the beauty the world has to offer. Delivered by AKYACHT in Summer 2021, she brings together Michael Leach Design and H2 Yacht Design.", "2 X Caterpillar", "4 X Caterpillar", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Meriadoc.png", "85.1 Metres", "16 Knots", 934700.00m, null, 5, 6, "Meriadoc", 1 },
                    { 5, 1, 28, "Peregrin was built for pure fun and adventure. With a 7,640 nautical mile range and equipped with all the latest toys, she offers pure unadulterated adventure, thrills and fun with all the luxuries you would come to expect of a superyacht from world-class cuisine to a dedicated spa centre, all whilst cruising the world’s remotest oceans. Not for charter to US residents while in US waters.", "2 X Smit-Man", "3 X John Deere", 28, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Peregrin.png", "77.4 Metres", "12 Knots", 604700.00m, null, 9, 11, "Peregrin", 1 },
                    { 6, 4, 21, "Enhance your Legolas experience: watch here the Chief Stewardess preparing the yacht's cocktail signature HOT WHEELS, and join the Captain here for a complete walkthrough. A certified family-friendly motor yacht for charter, 76m/249’ Legolas is undoubtedly one of the most acclaimed vessels in her range. Seven decks of outstanding features are spread over a volume of nearly 2,000GT . Legolas is operated by an Owner who has been meticulous in her maintenance and upgrades.", "2 X MTU", "3 X Caterpillar", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Legolas.png", "75.5 Metres", "18 Knots", 836300.00m, null, 4, 6, "Legolas", 1 },
                    { 7, 2, 19, "Having undergone an interior refit in 2018, 73M Lurssen yacht for charter Gimli is everything you would expect from such a renowned shipyard and more. Boasting magnificent spaces both inside and out she offers all the features of luxury life on a superyacht, including huge entertainment spaces, the very latest amenities and incredible accommodation.", "2 X Caterpillar", "2 X Caterpillar", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Gimli.png", "73 Metres", "16 Knots", 585400.00m, null, 10, 7, "Gimli", 1 },
                    { 8, 2, 30, "Smeagol is a recently refit 72M superyacht available for charter in the Mediterranean, the Balearics, Croatia, the Arabian Gulf, Indian Ocean and the Red Sea. She accommodates up to 28 guests in14 staterooms and boasts special features such as a Jacuzzi. Her spacious decks provide the ideal situation for relaxing with friends or family and taking in the scenery of the surrounding area.", "2 X MTU", "3 X MAN", 30, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Smeagol.png", "72 Metres", "16.2 Knots", 559000.00m, null, 3, 16, "Smeagol", 1 },
                    { 9, 4, 19, "Boromir offers the ultimate charter experience. She accommodates up to 26 guests in 13 beautiful staterooms, features a spa on board, in addition to a plethora of toys. Her luxurious interior décor and incredible facilities create the ideal charter yacht for large families or corporate events. Not for charter to US residents while in US waters.", "1 X Caterpillar", "2 X John Deere", 28, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Boromir.png", "69.65 Metres", "13 Knots", 492900.00m, null, 6, 13, "Boromir", 1 },
                    { 10, 2, 13, "Gandalf, the 54.3M Amels superyacht for charter, is a world cruiser designed for free spirits that harmoniously combines zen and adventure. She accommodates 11 guests in five staterooms and is available in the Caribbean and Central America. She boasts a contemporary interior and spacious decks, as well as an impressive range of water toys for guests' recreational enjoyment.", "2 X MTU", "3 X Northern Lights", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Gandalf.png", "54.3 Metres", "15.5 Knots", 299900.00m, null, 8, 5, "Gandalf", 1 },
                    { 11, 1, 14, "With her traditional lines and Feadship pedigree Saruman epitomises classic superyacht charm, yet delve a little deeper  and you find interiors and amenities at the highest levels of modern luxury. Saruman is committed to lowering its impact on the environment by making a conscious effort to reduce  its carbon footprint.", "2 X Caterpillar", "2 X Northern Lights", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Saruman.png", "53.1 Metres", "16 Knots", 203300.00m, null, 9, 8, "Saruman", 1 },
                    { 12, 2, 10, "Sauron is a beautiful 52m yacht for charter with accommodation for 12 guests in six comfortable staterooms. Spacious and classic in style, Sauron boasts a hot tub, sports bar, vast alfresco dining area and an abundant array of water toys. Her large party deck is ideal for entertaining.", "2 X Cummins", "3 X Northern Lights", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Sauron.png", "52.4 Metres", "15 Knots", 172100.00m, null, 7, 6, "Sauron", 1 },
                    { 13, 2, 11, "Smaug is a highly pedigreed yacht, blending modern and classic styles.  Accommodations include five spacious staterooms with three staterooms with king beds and two staterooms with queen beds.  Two of the kings convert to twin beds with two Pullman berths in each of these staterooms. Additional amenities include a wide assortment of water toys, exercise equipment, large tender, shade for alfresco dining, multiple areas for sunbathing and a Jacuzzi.", "2 X Caterpillar", "2 X Northern Lights", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Smaug.png", "51.1 Metres", "15 Knots", 249100.00m, null, 3, 5, "Smaug", 1 },
                    { 14, 1, 18, "Theoden is the ultimate platform for adventures and exploration around the stunning, remote waters of Indonesia and Asia. A traditional Indonesian Phinisi design launched in 2014, she offers stable and comfortable cruising with no compromise to luxury. Sleeping up to 14 guests in seven spacious and well-appointed staterooms, she features spacious outdoor decks for large groups of friends and families to enjoy while taking in the view.", "1 X Yanmar", "2 X Northern Lights", 50, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Theoden.png", "51 Metres", "12 Knots", 120000.00m, null, 1, 7, "Theoden", 1 },
                    { 15, 1, 14, "Highly custom designed, with an unmissable metallic blue hull and a sleek silhouette inspired by a modern jet fighter, Elrond combines stunning spaces with the latest technology and boasts a top speed of 25 knots. Featuring a striking open-plan contemporary interior and an award winning exterior, she is ideal for entertaining.", "2 X MTU", null, 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Elrond.png", "51 Metres", "25 Knots", 284600.00m, null, 10, 8, "Elrond", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1ac2956-407c-477d-a815-b8810123e73a", "AQAAAAEAACcQAAAAEAxPL0qT24oTZGkg4QZcN1ywkpkMFDwMCmoBLQ+TGGEgamLYw1ovXpqUrxoF4CXPCw==", "9a6721ca-c8ac-4286-8ea3-f3c49b32ea88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4307c84-2c11-46b3-b547-e0f081cd4fb8", "AQAAAAEAACcQAAAAEEVo2X3mx3wfXz+0KNI//XFp5KLiYgtXpqvU4S3ivEvb4sk0vaiHMHjKlx3Umv5f+Q==", "bca38c39-12fd-405c-a95b-57c1164254e6" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Delivered in 2020 and one of the finest jewels delivered\r\nby Benetti, 107m / 351' Frodo is a charter yacht of\r\nchoice in the 100m+/300'+ range. Built and designed by\r\nBenetti to discover every corner of the world, her striking\r\nlines are matched with an unrivaled level of luxury on all\r\ndecks.\r\nPowered by an unusual Rolls-Royce hybrid-electric\r\npropulsion, Frodo ensures wonderful fuel efficiency and a\r\nlong cruising range, making her eco-friendly with a\r\ncruising speed of 16 knots, and 18.5 knots top speed.");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Aragorn is one of the world's largest and most\nimpressive charter yachts, ideal for entertaining on a\ngrand scale. She boasts many special features including\na spa, a gym, a cinema and vast deck spaces. Her\ninterior is opulent and grand and she features not one but\ntwo Jacuzzis. Accommodating 36 guests in eighteen\nstaterooms she offers a large group or several small\ngroups the chance for the experience of a lifetime on the\nWest Mediterranean.\"");
        }
    }
}

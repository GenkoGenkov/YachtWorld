using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedAnotherYacht : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.png");

            migrationBuilder.InsertData(
                table: "Yachts",
                columns: new[] { "Id", "CategoryId", "CrewMembers", "Description", "Engines", "Generators", "Guests", "ImageUrl", "Length", "MaxSpeed", "PriceForRent", "SailorId", "ShipyardId", "StateRooms", "Title", "YachtBrokerId" },
                values: new object[] { 2, 2, 36, "Aragorn is one of the world's largest and most\nimpressive charter yachts, ideal for entertaining on a\ngrand scale. She boasts many special features including\na spa, a gym, a cinema and vast deck spaces. Her\ninterior is opulent and grand and she features not one but\ntwo Jacuzzis. Accommodating 36 guests in eighteen\nstaterooms she offers a large group or several small\ngroups the chance for the experience of a lifetime on the\nWest Mediterranean.\"", "2 X Caterpillar", "3 X Caterpillar", 36, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Aragorn.png", "91.4 Metres", "15 Knots", 645000.00m, null, 2, 18, "Aragorn", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9ca148d-a6ec-462f-bd76-02eccc9ef7be", "AQAAAAEAACcQAAAAEMjumDulxnp3RPT7tH1HpnDSRkz227DR2QiXn7PCwGU1uBY/2GnSTVIHSamoo8mQDQ==", "c6dd68e2-65d0-4961-953a-de4c7067290d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e38b7b6f-eecc-4a1f-bcfb-b424ea228985", "AQAAAAEAACcQAAAAEOqkKMqnbNsFj7diuPQMOoWLelvq/AcNmkGWq847vG3NdPl/J9shmoMdgBHcFnkL9Q==", "cd01a872-8af5-4418-8ee4-ceb48c1a3e9d" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.jpg");
        }
    }
}

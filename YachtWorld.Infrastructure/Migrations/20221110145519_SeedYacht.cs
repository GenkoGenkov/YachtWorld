using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedYacht : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Yachts",
                columns: new[] { "Id", "CategoryId", "CrewMembers", "Description", "Engines", "Generators", "Guests", "ImageUrl", "Length", "MaxSpeed", "PriceForRent", "SailorId", "ShipyardId", "StateRooms", "Title", "YachtBrokerId" },
                values: new object[] { 1, 1, 33, "Delivered in 2020 and one of the finest jewels delivered\r\nby Benetti, 107m / 351' Frodo is a charter yacht of\r\nchoice in the 100m+/300'+ range. Built and designed by\r\nBenetti to discover every corner of the world, her striking\r\nlines are matched with an unrivaled level of luxury on all\r\ndecks.\r\nPowered by an unusual Rolls-Royce hybrid-electric\r\npropulsion, Frodo ensures wonderful fuel efficiency and a\r\nlong cruising range, making her eco-friendly with a\r\ncruising speed of 16 knots, and 18.5 knots top speed.", null, "3 X Caterpillar", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.jpg", "107 Metres", "18.5 Knots", 1800000.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 1, 8, "Frodo", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1296eb92-4563-4b66-9466-3f275dfe227c", "AQAAAAEAACcQAAAAEGjfmm3MHSvsMsd9WcFnblSNUTYDe3mY9JnKYvUX/6IDt1Rl4h2TbxpukrC0YnBIeg==", "bf8e8019-def5-4292-983c-ed41cac43325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0287e509-fb57-4d3f-98fb-df3c61748353", "AQAAAAEAACcQAAAAENX9J90IZKzAc1emT5fDgia0GBIAvd2+JkLd097++3BdmLxCMqn0zMeZVTuqSFOu2g==", "0bf329ba-b3b6-4426-a674-090fa70f4a74" });
        }
    }
}

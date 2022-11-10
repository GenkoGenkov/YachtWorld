using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedShipyards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b2b2c75-449d-476e-a018-fd075fa0cca7", "AQAAAAEAACcQAAAAEPS2++Hn5N0U/gPxZaQo1UFTBl74L6Y0SkTxeUpDU5ahVnfPcL8dGPlGo2hPwvvrnQ==", "c011cef4-2504-4fab-9bec-2444aeb27219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c0a30e7-5582-434c-9c06-d36855b200fd", "AQAAAAEAACcQAAAAEOFrCEV/SxDLSHszQs3Pna97hjAsK9TMh+iKqreypO2DLD/56+g2N6gmkx6VbHvRDA==", "b15118c2-e28a-4ab6-adf4-4cf460ad2ab1" });

            migrationBuilder.InsertData(
                table: "Shipyards",
                columns: new[] { "Id", "EstablishedIn", "Location", "Name" },
                values: new object[,]
                {
                    { 1, 1980, "New Zealand", "Alloy Yachts" },
                    { 2, 1918, "Germany", "Amels Yachts" },
                    { 3, 1969, "Italy", "Azimut Yachts" },
                    { 4, 1854, "Port of Genova", "Baglietto" },
                    { 5, 1873, "Italy", "Benetti Yachts" },
                    { 6, 1863, "USA", "Burger" },
                    { 7, null, "Vancouver Washington", "Cristensen Yachts" },
                    { 8, 1825, "Italy", "Codecasa Yachts" },
                    { 9, 1919, "Holland", "Hakvoort Yachts" },
                    { 10, 1960, "Brazil", "Inace" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shipyards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "790cc6b2-c594-4b21-9aa6-ff7e4a9e2aad", "AQAAAAEAACcQAAAAENic8Gl4bdcd0iUswtt/3gk9OzTiIHIGhRXZ/xg7xkIDfKv1RLvGDiHuTADt5QZzQg==", "249082b4-be5d-4bdb-9548-19def15c123f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e199acb2-e87d-4ded-b117-5e1378f83782", "AQAAAAEAACcQAAAAELR77AauSeObpgvlQ3X2jOz+GBN94wd70u/w7C9sWYWpuIZfHsTH5lQCNpRZMtlruQ==", "a0907762-a0f9-42c8-a828-41b9b859487c" });
        }
    }
}

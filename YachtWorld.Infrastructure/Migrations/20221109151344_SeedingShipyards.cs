using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedingShipyards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97d3a98d-4a86-4f31-8c7d-b228077f60e1", "AQAAAAEAACcQAAAAEJ+cAuRb2JTBPOVbocxQwzAPoP3BL5izkAlHO471YJOiM7Nvpwe7ApFKyUc+DaaBrA==", "17e2b893-3078-4a55-b9d4-83b8f4809d72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c52c8e5c-2793-43d9-b30c-c57adadf4260", "AQAAAAEAACcQAAAAENiGL6wrvb9qNkPOH5+WrfYcqgt+QN9M0btGVvRFDWkiZWj3AbRc38PuumoU/TcPfw==", "6be36e9b-225c-4aea-9fb9-bef8dbe99985" });

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
                values: new object[] { "1a7e814d-182a-42ab-a885-26d5b36c7cbc", "AQAAAAEAACcQAAAAEIgxRhzFJrkORTyIfsurKBrjPpvCNyv7dzBJZu3SQkbDB8V2u7kc4ezCO8nTzBsUQw==", "1596bdc1-ce8c-4a06-b87e-feea1ea8cf63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c32c8d1-df00-487b-8970-139c9e5c4ad6", "AQAAAAEAACcQAAAAEE1knQK0GfuCW6Sv3VjCnImXXxqI5Cqj4Zb7aqIFQTYiuCLYQ+bUzSrsEBrbHfDXxA==", "e660fc40-70de-49d9-9d9e-b1cc1c393d8c" });
        }
    }
}

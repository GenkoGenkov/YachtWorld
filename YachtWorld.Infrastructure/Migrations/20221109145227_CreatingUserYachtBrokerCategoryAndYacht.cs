using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class CreatingUserYachtBrokerCategoryAndYacht : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "YachtBrokers");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "YachtBrokers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "1a7e814d-182a-42ab-a885-26d5b36c7cbc", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEIgxRhzFJrkORTyIfsurKBrjPpvCNyv7dzBJZu3SQkbDB8V2u7kc4ezCO8nTzBsUQw==", null, false, "1596bdc1-ce8c-4a06-b87e-feea1ea8cf63", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "8c32c8d1-df00-487b-8970-139c9e5c4ad6", "yachtBroker@mail.com", false, false, null, "yachtBroker@mail.com", "yachtBroker@mail.com", "AQAAAAEAACcQAAAAEE1knQK0GfuCW6Sv3VjCnImXXxqI5Cqj4Zb7aqIFQTYiuCLYQ+bUzSrsEBrbHfDXxA==", null, false, "e660fc40-70de-49d9-9d9e-b1cc1c393d8c", false, "yachtBroker@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Green-Yachts" },
                    { 2, "Yacht-With-Captain" },
                    { 3, "Explorer" },
                    { 4, "Large" }
                });

            migrationBuilder.InsertData(
                table: "YachtBrokers",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 1, "+359888888888", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Yachts",
                columns: new[] { "Id", "CategoryId", "CrewMembers", "Description", "Engines", "Generators", "Guests", "ImageUrl", "Length", "MaxSpeed", "PriceForRent", "SailorId", "ShipyardId", "StateRooms", "Title", "YachtBrokerId" },
                values: new object[] { 1, 1, 33, "Delivered in 2020 and one of the finest jewels delivered\r\nby Benetti, 107m / 351' Frodo is a charter yacht of\r\nchoice in the 100m+/300'+ range. Built and designed by\r\nBenetti to discover every corner of the world, her striking\r\nlines are matched with an unrivaled level of luxury on all\r\ndecks.\r\nPowered by an unusual Rolls-Royce hybrid-electric\r\npropulsion, Frodo ensures wonderful fuel efficiency and a\r\nlong cruising range, making her eco-friendly with a\r\ncruising speed of 16 knots, and 18.5 knots top speed.", null, "3 X Caterpillar", 12, "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.jpg", "107 Metres", "18.5 Knots", 1800000.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 1, 8, "Frodo", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "YachtBrokers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "YachtBrokers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "YachtBrokers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}

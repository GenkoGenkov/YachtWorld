using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedADestinations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33a73996-9b8f-474c-8d30-7140a46f6b31", "AQAAAAEAACcQAAAAEHqHnCAYW8EJ49lm6GtorxU6jJW733+VsUXbiRbVnrjgV7vFHk+btNm3Sh7HUmgtmg==", "a20cd6b3-5c4b-41af-9cb5-cb8c60174312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28d964b5-0e22-4567-87d4-fe7b2c27a6fb", "AQAAAAEAACcQAAAAEFMWSi7kQ0cgbdMBgfyqNCroOqCVU5MekmLXJtuVZmHMxmVjnRWVE9L/srg7+rvDBw==", "f83a6b3c-f01f-4f0e-b318-7178fca5423c" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "MainAttraction", "Name", "YachtId" },
                values: new object[,]
                {
                    { 1, "Cannes Film Festival", "Mediterannean", 1 },
                    { 2, "Tropical Climate", "Caribbean", 2 },
                    { 3, "Swim by a Waterfall", "Australasia", 3 },
                    { 4, "Northern Lights", "Northern Europe", 4 },
                    { 5, "Flourishing Nature", "South Pacific", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5);

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
        }
    }
}

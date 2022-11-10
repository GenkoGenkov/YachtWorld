using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396d53e0-3aae-4037-b910-fa0d02e0f9ec", "AQAAAAEAACcQAAAAEIJ2VuRCjqfzFnUCloSGHZ+l6A8zNPQjxywHULc5KcbUvH5rnjsCYhG5Mc8lxpwytA==", "ab5fbdbd-2feb-4f20-8ed0-2282bda48c63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c68c130-4235-4ff5-a84d-5350e205963f", "AQAAAAEAACcQAAAAEFuzLJLMR3ZNxBTPLSGqPsxlHqzIQopwbJW8TfJ/Iop4NTOFhqu7XeCgeGPTnOUfyA==", "4a76761c-0154-437d-bbcc-9e2b4a03dbc2" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c481071f-c435-41ad-820a-4c2fee4298f1", "AQAAAAEAACcQAAAAEHJ/CFgavtP7zeNHkg2dHkmBJKErMz1uRMC+dTRVobb6N7Gpu/L82cZlfK3AKXEKxw==", "a395e3e1-81b4-4151-860a-87d017d5b271" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3e06ff0-4188-44a2-af1f-74fda48ec463", "AQAAAAEAACcQAAAAEPmKChBjk9nlG2acX5M62VbJjupDWas0oSCw4hNx754vCKQkaki1lfHHm/5GgIZdNA==", "37b41674-f4dd-4618-8736-89b37000192c" });
        }
    }
}

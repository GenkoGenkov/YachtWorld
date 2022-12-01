using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7bb8971-1068-40b2-a01f-a943a5acc09a", "AQAAAAEAACcQAAAAEKyQDV4xcMQ0b484sF8OQZiXgXwmNoL8lxmlt7GOH4YPxf7RSk2QBg6BNoicwTBv5A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28d3b169-bce9-409e-b940-492e6108558a", "AQAAAAEAACcQAAAAEHlXbatRtox8Fvze5QqoPs+f9tir52gf74Dq3fr39a1ONJjX/O+l59/EJo5l87EfAQ==", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "012479d3-87cc-4315-800e-75b832e6a746", "AQAAAAEAACcQAAAAEApiEAzYiRWWmgEhljNaBSvkOIdkaccxiPT+x2ebqcgrIpqBC4onqyLIAU5qjhDhCw==", "f7d4fef4-0d9a-46fb-8f7b-f6453136384b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a0c962f-2f60-4507-9140-cf6c2c9d139a", "AQAAAAEAACcQAAAAEGEh6ji/KtCkzObxhn6v8nxz0lrR/0S5YtseN5G934ebipc6Iqe7ik+GjseRRYBIhQ==", "e4d4e137-716a-42b0-81dd-7bf6750dffe8" });
        }
    }
}

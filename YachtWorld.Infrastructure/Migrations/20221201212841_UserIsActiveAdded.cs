using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class UserIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "958cf25a-0316-46a7-b649-15fdb919b21e", "AQAAAAEAACcQAAAAEISMUtJi5JpWX6FO9sAg3xPeGsmfUB9s9qzVJrcL7SxydBvy2g0iExui973irMUgBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0be6b620-0a88-4226-b52e-79d95a26d213", "AQAAAAEAACcQAAAAELfN+0IdRwWdxzlvwq9GZoWiK+FFzu1MoY8EEcIqltgN3mFVpSMWYCLir0tCe/TyGw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f7bb8971-1068-40b2-a01f-a943a5acc09a", "AQAAAAEAACcQAAAAEKyQDV4xcMQ0b484sF8OQZiXgXwmNoL8lxmlt7GOH4YPxf7RSk2QBg6BNoicwTBv5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28d3b169-bce9-409e-b940-492e6108558a", "AQAAAAEAACcQAAAAEHlXbatRtox8Fvze5QqoPs+f9tir52gf74Dq3fr39a1ONJjX/O+l59/EJo5l87EfAQ==" });
        }
    }
}

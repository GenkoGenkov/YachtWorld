using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class YachtIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Yachts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "012479d3-87cc-4315-800e-75b832e6a746", "AQAAAAEAACcQAAAAEApiEAzYiRWWmgEhljNaBSvkOIdkaccxiPT+x2ebqcgrIpqBC4onqyLIAU5qjhDhCw==", "f7d4fef4-0d9a-46fb-8f7b-f6453136384b" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "6a0c962f-2f60-4507-9140-cf6c2c9d139a", "AQAAAAEAACcQAAAAEGEh6ji/KtCkzObxhn6v8nxz0lrR/0S5YtseN5G934ebipc6Iqe7ik+GjseRRYBIhQ==", "e4d4e137-716a-42b0-81dd-7bf6750dffe8" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Yachts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d29cf78-df31-423b-bf23-2349f06cd647", "AQAAAAEAACcQAAAAEDOTTULxW6NwGkohV32QpBZVeMZNYUUlYVs1opvWjdj33BAfqI1odv9iYNpuddu6dg==", "ce377a09-f5a3-405d-93af-8c60e7e7090f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b4998be-ed84-4080-a75c-1c4ef38d22de", "AQAAAAEAACcQAAAAEFyxXLBNimb8vmLcC5S2Kp8r0SXis4LinfHMyqSPbvwJ896woYg+RNBX3c0VoaG1yw==", "064b4bb8-8d2b-4de4-8498-76a77cc1ea5d" });
        }
    }
}

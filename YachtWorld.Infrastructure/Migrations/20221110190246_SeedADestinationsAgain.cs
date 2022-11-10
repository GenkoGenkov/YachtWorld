using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedADestinationsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Yachts_YachtId",
                table: "Destinations");

            migrationBuilder.AlterColumn<int>(
                name: "YachtId",
                table: "Destinations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c31e265e-aaa0-4b40-bee0-eccf7a79e028", "AQAAAAEAACcQAAAAEOBr68yEr7XOhODZP3MJzjurHq9nzikSRDCRgW4SEzrCDSnOvn5sRkOvi9aQgzxC0w==", "a3baf25c-7abe-414b-afaf-596ae6cd30a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "261efc80-bbef-4e50-80db-74fec2fc2018", "AQAAAAEAACcQAAAAENg+m6Octa2a/P7FzYiti5w4rJBLqWxQ0IoNCRQRCHlagHqCLbM0EmxA8bJP1JAljg==", "524a8b0a-d43d-4156-aef9-248c8275bf74" });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "YachtId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "YachtId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "YachtId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "YachtId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "YachtId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Yachts_YachtId",
                table: "Destinations",
                column: "YachtId",
                principalTable: "Yachts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Yachts_YachtId",
                table: "Destinations");

            migrationBuilder.AlterColumn<int>(
                name: "YachtId",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                column: "YachtId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                column: "YachtId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 3,
                column: "YachtId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 4,
                column: "YachtId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 5,
                column: "YachtId",
                value: 5);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Yachts_YachtId",
                table: "Destinations",
                column: "YachtId",
                principalTable: "Yachts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

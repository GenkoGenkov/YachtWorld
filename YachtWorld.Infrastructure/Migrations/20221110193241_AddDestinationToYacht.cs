using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class AddDestinationToYacht : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Yachts_YachtId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_YachtId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "YachtId",
                table: "Destinations");

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Yachts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e91de83-ad05-4087-b755-8c9ff2268bb1", "AQAAAAEAACcQAAAAEKF66heXhKxPlx5dO+Frcg8d0hIbUfiNeMES4qv39rCMuyuE059ogse4FrjFZ5hiVA==", "56ed46c2-5a03-4747-8b23-6589567961c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05ff3575-52f9-4566-a4e6-96746446f8af", "AQAAAAEAACcQAAAAEEb0O2z8Ivrou1UkfWRW5b0Rr6ApoVF0o3UCk3scXtmCGSH6l630QJxXjMhrFc9swg==", "fb8868b9-be80-428c-8684-7f061c9e38a9" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "DestinationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 2,
                column: "DestinationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 3,
                column: "DestinationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 4,
                column: "DestinationId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 5,
                column: "DestinationId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 6,
                column: "DestinationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 7,
                column: "DestinationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 8,
                column: "DestinationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 9,
                column: "DestinationId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 10,
                column: "DestinationId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 11,
                column: "DestinationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 12,
                column: "DestinationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 13,
                column: "DestinationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 14,
                column: "DestinationId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 15,
                column: "DestinationId",
                value: 5);

            migrationBuilder.CreateIndex(
                name: "IX_Yachts_DestinationId",
                table: "Yachts",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yachts_Destinations_DestinationId",
                table: "Yachts",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yachts_Destinations_DestinationId",
                table: "Yachts");

            migrationBuilder.DropIndex(
                name: "IX_Yachts_DestinationId",
                table: "Yachts");

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Yachts");

            migrationBuilder.AddColumn<int>(
                name: "YachtId",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f726267-0cbc-4a85-b606-35cdc2e78caa", "AQAAAAEAACcQAAAAEP/xF7uVwa3V2AP+DUz2yRT/tMZsKyXpQIt+GWHsbiDN2SWB7kuMT52uEriipcDBpA==", "744489ab-020f-40e9-9069-597925568a47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b968b017-926f-4fc9-aea3-b3b6db206c33", "AQAAAAEAACcQAAAAELm8nEwIBYikwfxJAIC2kzIiELM/t1fSF04RzChKA7ifh4eXYiCTQmEIxPPJkc9Kug==", "dcf5f7d0-4423-4170-88d9-92862b9d5dcb" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_YachtId",
                table: "Destinations",
                column: "YachtId");

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

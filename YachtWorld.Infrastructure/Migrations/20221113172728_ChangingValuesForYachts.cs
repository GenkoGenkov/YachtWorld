using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class ChangingValuesForYachts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Guests",
                table: "Yachts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80374a8c-8238-4171-b48d-3971c8788559", "AQAAAAEAACcQAAAAEAugN1YrmoWemCMzeyaGohUojj5spsmpr8r/Z9jtrQc+x6uKDntaE7LwWk6QJ2i0Eg==", "60335a2c-c10b-4a7a-afc5-c4903e36d4bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01fe5855-9ce7-4551-accf-fd3cbeba179b", "AQAAAAEAACcQAAAAECEMuRmoaOeKlBLF/YBVbjBSbsT3iL6FUbC8QJoV4K1+MMp0153HdMlCQD0BdYb/YA==", "64c8d0eb-cf60-4c52-9f6f-744312680124" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Guests",
                table: "Yachts",
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
                values: new object[] { "5ee7dab8-aae1-471a-bb6d-9d994693fa89", "AQAAAAEAACcQAAAAEFNBPw/88v6u3+HCTuTOXJsbFNN3Omf3uy+TXNK7dhAlLY3GVRT8yY9sUS3TWY5jzA==", "d55de6cc-e132-4242-b3fb-4946ce12961d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b871829-738a-46a5-99bc-c8a643fea82b", "AQAAAAEAACcQAAAAEKcqVPys6BDaBGNZGGJPXxijTD9F22Q6nnwRPFoXBJF+xFJJShbZu97mA8IARKn11w==", "9ad7e881-04dc-45e1-b081-e5357d435942" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class ChangeEmailToPhoneNumberForYachtBroker : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash" },
                values: new object[] { "b9b28bea-5524-498c-ae00-a2f3a084e8ac", true, "AQAAAAEAACcQAAAAEHB8MRxnnRQoXM1KMwzdE8p9xYBMygTjQHWUlgN1vsWfsGJXrR5LdzdC7RVaQsm2mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash" },
                values: new object[] { "9c6c5a0f-e1fb-4103-9815-5563da158ee4", true, "AQAAAAEAACcQAAAAEFk2ZnHnn/X84wr6VV32t/cWK6zS0zrCPnotqHzbc/83eGw2hz/Zy/YM7peFLmromg==" });

            migrationBuilder.UpdateData(
                table: "YachtBrokers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNumber",
                value: "+359888888888");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash" },
                values: new object[] { "958cf25a-0316-46a7-b649-15fdb919b21e", false, "AQAAAAEAACcQAAAAEISMUtJi5JpWX6FO9sAg3xPeGsmfUB9s9qzVJrcL7SxydBvy2g0iExui973irMUgBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash" },
                values: new object[] { "0be6b620-0a88-4226-b52e-79d95a26d213", false, "AQAAAAEAACcQAAAAELfN+0IdRwWdxzlvwq9GZoWiK+FFzu1MoY8EEcIqltgN3mFVpSMWYCLir0tCe/TyGw==" });

            migrationBuilder.UpdateData(
                table: "YachtBrokers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "yachtBroker@mail.com");
        }
    }
}

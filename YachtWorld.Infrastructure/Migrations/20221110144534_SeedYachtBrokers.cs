using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedYachtBrokers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b074ed6a-d2f7-43de-bfb9-a0939ed7853e", "AQAAAAEAACcQAAAAEKaCbGfK+JaVP/p2mcoKK6AHalvXIlbirnrLY5/38ehPY8E9gsRfsqY79ktBMSgKqA==", "7548c60e-4724-41af-af0b-850d6ec85450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ada76a27-9c5d-4319-a152-507406dd49b2", "AQAAAAEAACcQAAAAEIoJOrE4VPpuddBxpC1dmLI7Q0+f9DdpSyQbB6UkDnPw9FM3Oi/fuom5L4Mio5eP5w==", "47b1c95e-1e82-497a-8ca0-9d2d17f15dc0" });

            migrationBuilder.InsertData(
                table: "YachtBrokers",
                columns: new[] { "Id", "Email", "UserId" },
                values: new object[] { 1, "yachtBroker@mail.com", "dea12856-c198-4129-b3f3-b893d8395082" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "YachtBrokers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b692b1-430b-4765-ac1e-9952fb516971", "AQAAAAEAACcQAAAAEBmJh98EoGbjjpROUOq10QCm/XSmphvRDOyhPVJj3RnfaZwLufFTo8IFsdQ7W+xWRg==", "ba5ca35d-8c85-4823-8932-5b5b108b94ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42d7c3b4-d06e-491f-b0bd-c8ff93d9b008", "AQAAAAEAACcQAAAAENDxB2OFGidlHg/JRGmuBfF4FWcvxSTfeJNv67fY/FwIrzA6P1uA6SY7ykCszhAgxQ==", "6d202b2a-b6b3-45ae-92fe-e768457d8ffa" });
        }
    }
}

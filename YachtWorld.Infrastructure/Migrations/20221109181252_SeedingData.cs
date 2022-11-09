using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81e15583-4019-495a-9507-fe9f72b9b9f4", "AQAAAAEAACcQAAAAEPhjWmXQWPz5+mE+d+pzvYMbsSH1GUMsCNMYlrwRUSnM0gaNBqLiP6Gglppzp7IgsQ==", "ce6caeb8-ab23-4041-96b9-89bed4bf5b80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b46f2e9-e9cb-4ec7-9296-6edcddbe6f7c", "AQAAAAEAACcQAAAAEN04lwLOuEdvYbAFRO+voFCkaa0jznSs5i1TgjW5ixKS04HPUPjl5yHAu9PLuFzjig==", "cdd3640b-951a-4929-9111-08ae35064492" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1bf879-695c-481c-b40a-610bb495ebb3", "AQAAAAEAACcQAAAAEGJO1ak6MsXgDQn0gOFvxD9gmWaTclW73pn45ZNoigzu3hOh+dWaGUBm8xYzO81HAw==", "cc5f233e-e047-4c37-9ee1-2f486b074782" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f832e96-eb5b-46a3-8ce8-0cb875b06a86", "AQAAAAEAACcQAAAAEDPAIAY6bsGago81CDkmo6yiqhp1Yde4YiXEfc3CrqCBbWjqcqRp8XutbqJGqiRBuA==", "629d9ab6-a946-4b33-be2a-e9a075c63a1d" });
        }
    }
}

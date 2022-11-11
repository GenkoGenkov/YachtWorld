using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class ChangingYachtFrodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "033c04f5-9eca-465e-b7a6-0e755a9cdbea", "AQAAAAEAACcQAAAAELgaJYnT1RoIa/bivXsCNZJFOJqGa3fmNEIwTqgxz+AOm7onzM5FS/Q+5+sSXIx5Ug==", "804e6a45-bbab-42e5-ac03-8599b6dd041d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47ef41d7-9336-48ce-b3c6-13ffaca5e449", "AQAAAAEAACcQAAAAEKjrGPM8OJGzd6Z1f3nRyje3e7eIddzWpZik6nRFmqHcK8FSyUmNvW9voHxnAUeE8w==", "81ebec4d-da08-45ce-88f3-f5eafb8d85ac" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://dynaimage.cdn.cnn.com/cnn/q_auto,w_1100,c_fill,g_auto,h_619,ar_16:9/http%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F210701131326-worlds-largest-yacht--credit--winch-design-3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aba0eaf0-ab83-428a-a2e2-56129ffc7e87", "AQAAAAEAACcQAAAAENkKz0A/XfxS83HWML3SqllUvWijLmKHir+cOmCp55flLqMFZyEaSqYFaZB5kyiPRw==", "1d7057bd-3525-47af-907b-5a7b0f0a819c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e4f91ae-3594-41bf-9970-58396d902a70", "AQAAAAEAACcQAAAAEJbFlulHbESJ1rQOYUiU9Sm32JOB+h90/rpR4uwagvj9EUku8v7DX2lFPmr3MamvCg==", "e2c21511-2d1c-49fe-83f3-bfb50daf6135" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.png");
        }
    }
}

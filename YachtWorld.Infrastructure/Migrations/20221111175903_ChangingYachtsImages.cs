using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class ChangingYachtsImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f67cc97-3b50-4222-a5ae-301faa5df60d", "AQAAAAEAACcQAAAAEMZCL3gMbNa/jjTWCTFLQ4lH21eB/6ZXX/VKn4LBSy3roLGysJoOUZ7nf1KTeuOB3g==", "4c038685-981e-437a-944f-8ee17b50fbbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7a7c97a-b0c2-4f90-817c-f8ebd4038e65", "AQAAAAEAACcQAAAAEIgQ0Bp76EYDEkp3ebkCnyr0BIw09peVKFJj/OJimu6AiU/pwU9OktncVoEkyiUXIg==", "8c9b4ba5-5d6e-4589-95fd-e71b499071b2" });

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://media.cntraveler.com/photos/633465b708c8c4ac97ede225/master/pass/four%20seasons%20yacht-sept22-pr4.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://moranyachts.imgix.net/wp-content/uploads/Luxury-yacht-Lurssen-Marguertie-for-charter-0402.jpg?auto=format&fit=crop&fm=webp%26nbsp%3B2x&h=320&ixlib=php-3.1.0&w=535&s=98ca6fe304806a46cea19caac252926c");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://yachtharbour.com/static/uploads/scale_1240_d3197.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://media.fraseryachts.com/Yachts/Y46_MC_MC/images/website/Benetti_yacht_for_charter_Formosa_22555-nHJHhqpS.jpg?vh=d79e30");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.wartsila.com/images/default-source/marine-pictures/yachts/super-intelligent-yachts.jpg?sfvrsn=355a4043_3");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://yachtharbour.com/static/uploads/scale_1240_0e8d9.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "http://cdn.cnn.com/cnnnext/dam/assets/211109221217-02-somnio-residential-superyacht.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://media.fraseryachts.com/Yachts/Y6063_MC_MC/images/website/Benetti_yacht_for_sale_Alfa_20603-wUutHQHe.jpg?vh=51ce02");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://nasco-yachts.com/wp-content/uploads/2021/09/Miami-Super-yacht-rental-at-sea.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://iycstorage.s3.amazonaws.com/import/wordpress/2015/09/Yacht_Impromptu_Superyacht_charter_profile.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://cdn.boatinternational.com/files/2020/12/7a18d620-3bcb-11eb-957a-6996e21593a4-top-25-nord-credit-Tom-Van-Oossanen.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://photo-assets.superyachttimes.com/photo/53338/image/large-c3d76ea97da2917a035084f5523f38b4.jpg");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://images.mansionglobal.com/im-361289?width=1280&size=1.77777778");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://cdn-bnkbk.nitrocdn.com/nAFpEbfLTzfNdwqrFBzzCzGgTRTvTBTC/assets/static/optimized/rev-88cb8a7/wp-content/uploads/2021/01/Yacht-Holiday-Indonesia-1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Aragorn.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Samwise.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Meriadoc.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Peregrin.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Legolas.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Gimli.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Smeagol.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Boromir.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Gandalf.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Saruman.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Sauron.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Smaug.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Theoden.png");

            migrationBuilder.UpdateData(
                table: "Yachts",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Elrond.png");
        }
    }
}

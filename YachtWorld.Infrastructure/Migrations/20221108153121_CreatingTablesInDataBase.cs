using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    public partial class CreatingTablesInDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipyards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstablishedIn = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipyards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YachtBrokers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YachtBrokers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YachtBrokers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yachts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    PriceForRent = table.Column<decimal>(type: "money", precision: 18, scale: 3, nullable: false),
                    Guests = table.Column<int>(type: "int", nullable: false),
                    StateRooms = table.Column<int>(type: "int", nullable: false),
                    CrewMembers = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engines = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generators = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    YachtBrokerId = table.Column<int>(type: "int", nullable: false),
                    SailorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ShipyardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yachts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yachts_AspNetUsers_SailorId",
                        column: x => x.SailorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Yachts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yachts_Shipyards_ShipyardId",
                        column: x => x.ShipyardId,
                        principalTable: "Shipyards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yachts_YachtBrokers_YachtBrokerId",
                        column: x => x.YachtBrokerId,
                        principalTable: "YachtBrokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MainAttraction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YachtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Destinations_Yachts_YachtId",
                        column: x => x.YachtId,
                        principalTable: "Yachts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_YachtId",
                table: "Destinations",
                column: "YachtId");

            migrationBuilder.CreateIndex(
                name: "IX_YachtBrokers_UserId",
                table: "YachtBrokers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Yachts_CategoryId",
                table: "Yachts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Yachts_SailorId",
                table: "Yachts",
                column: "SailorId");

            migrationBuilder.CreateIndex(
                name: "IX_Yachts_ShipyardId",
                table: "Yachts",
                column: "ShipyardId");

            migrationBuilder.CreateIndex(
                name: "IX_Yachts_YachtBrokerId",
                table: "Yachts",
                column: "YachtBrokerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Yachts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Shipyards");

            migrationBuilder.DropTable(
                name: "YachtBrokers");
        }
    }
}

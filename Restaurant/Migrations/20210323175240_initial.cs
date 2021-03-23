using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "restaurantBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantMenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantBases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "restaurantDetails",
                columns: table => new
                {
                    RestaurantDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anayemek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meze = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salatalar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    İçecek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tatlılar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantDetails", x => x.RestaurantDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "restaurantBases");

            migrationBuilder.DropTable(
                name: "restaurantDetails");
        }
    }
}

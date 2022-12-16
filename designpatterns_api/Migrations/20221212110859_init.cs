using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace designpatternsapi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Heels = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    SaleProcent = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWaterproof = table.Column<bool>(type: "bit", nullable: false),
                    WatchType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Wristband = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    SaleProcent = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.DropTable(
                name: "Watches");
        }
    }
}

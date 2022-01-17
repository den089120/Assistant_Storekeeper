using Microsoft.EntityFrameworkCore.Migrations;

namespace Assistant_Storekeeper.Migrations
{
    public partial class AddProductAndMoveProductToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoveProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduct = table.Column<int>(type: "int", nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseOut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeValue = table.Column<int>(type: "int", nullable: false),
                    DateIn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoveProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warehouse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductValue = table.Column<int>(type: "int", nullable: false),
                    DateIn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoveProducts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeEShop.Data.Migrations
{
    public partial class AddInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikesId = table.Column<int>(type: "int", nullable: false),
                    ColorsId = table.Column<int>(type: "int", nullable: false),
                    SizesId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_BikeColor_BikesId_ColorsId",
                        columns: x => new { x.BikesId, x.ColorsId },
                        principalTable: "BikeColor",
                        principalColumns: new[] { "BikesId", "ColorsId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventory_BikeSize_BikesId_SizesId",
                        columns: x => new { x.BikesId, x.SizesId },
                        principalTable: "BikeSize",
                        principalColumns: new[] { "BikesId", "SizesId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_BikesId_ColorsId",
                table: "Inventory",
                columns: new[] { "BikesId", "ColorsId" });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_BikesId_SizesId",
                table: "Inventory",
                columns: new[] { "BikesId", "SizesId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}

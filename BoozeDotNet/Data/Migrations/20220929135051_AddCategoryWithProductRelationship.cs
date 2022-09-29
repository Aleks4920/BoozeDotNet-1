using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoozeDotNet.Data.Migrations
{
    public partial class AddCategoryWithProductRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Categoryid",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Categoryid",
                table: "Product",
                column: "Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_Categoryid",
                table: "Product",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_Categoryid",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Product_Categoryid",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Categoryid",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Product");
        }
    }
}

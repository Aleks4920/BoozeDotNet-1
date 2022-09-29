using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoozeDotNet.Data.Migrations
{
    public partial class FixCategoryIdProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_Categoryid",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Categoryid",
                table: "Product",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_Categoryid",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Product",
                newName: "Categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                newName: "IX_Product_Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_Categoryid",
                table: "Product",
                column: "Categoryid",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

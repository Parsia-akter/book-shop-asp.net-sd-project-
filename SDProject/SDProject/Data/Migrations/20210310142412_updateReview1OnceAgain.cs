using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class updateReview1OnceAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review1_Product_ProductId",
                table: "Review1");

            migrationBuilder.DropIndex(
                name: "IX_Review1_ProductId",
                table: "Review1");

            migrationBuilder.DropColumn(
                name: "GetProductId",
                table: "Review1");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Review1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GetProductId",
                table: "Review1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Review1",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review1_ProductId",
                table: "Review1",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review1_Product_ProductId",
                table: "Review1",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

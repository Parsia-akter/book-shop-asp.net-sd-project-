using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class addPractiseTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GetProductId",
                table: "PractiseTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "PractiseTable",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PractiseTable_ProductId",
                table: "PractiseTable",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_PractiseTable_Product_ProductId",
                table: "PractiseTable",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PractiseTable_Product_ProductId",
                table: "PractiseTable");

            migrationBuilder.DropIndex(
                name: "IX_PractiseTable_ProductId",
                table: "PractiseTable");

            migrationBuilder.DropColumn(
                name: "GetProductId",
                table: "PractiseTable");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "PractiseTable");
        }
    }
}

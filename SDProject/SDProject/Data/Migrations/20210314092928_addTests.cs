using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class addTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropForeignKey(
                name: "FK_PractiseTable_Product_GetProductId",
                table: "PractiseTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Test1_Product_GetProductId",
                table: "Test1");

            migrationBuilder.AlterColumn<int>(
                name: "GetProductId",
                table: "Test1",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GetProductId",
                table: "PractiseTable",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PractiseTable_Product_GetProductId",
                table: "PractiseTable",
                column: "GetProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Test1_Product_GetProductId",
                table: "Test1",
                column: "GetProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PractiseTable_Product_GetProductId",
                table: "PractiseTable");

            migrationBuilder.DropForeignKey(
                name: "FK_Test1_Product_GetProductId",
                table: "Test1");

            migrationBuilder.AlterColumn<int>(
                name: "GetProductId",
                table: "Test1",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GetProductId",
                table: "PractiseTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PractiseTable_Product_GetProductId",
                table: "PractiseTable",
                column: "GetProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Test1_Product_GetProductId",
                table: "Test1",
                column: "GetProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);*/
        }
    }
}

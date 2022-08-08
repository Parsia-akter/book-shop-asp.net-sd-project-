using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class addTestssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*  migrationBuilder.DropForeignKey(
                  name: "FK_PractiseTable_Product_GetProductId",
                  table: "PractiseTable");

              migrationBuilder.DropForeignKey(
                  name: "FK_Test1_Product_GetProductId",
                  table: "Test1");

              migrationBuilder.DropIndex(
                  name: "IX_PractiseTable_GetProductId",
                  table: "PractiseTable");

              migrationBuilder.AlterColumn<int>(
                  name: "GetProductId",
                  table: "Test1",
                  nullable: false,
                  oldClrType: typeof(int),
                  oldType: "int",
                  oldNullable: true);

              migrationBuilder.AlterColumn<int>(
                  name: "GetProductId",
                  table: "PractiseTable",
                  nullable: false,
                  oldClrType: typeof(int),
                  oldType: "int",
                  oldNullable: true);

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

              migrationBuilder.AddForeignKey(
                  name: "FK_Test1_Product_GetProductId",
                  table: "Test1",
                  column: "GetProductId",
                  principalTable: "Product",
                  principalColumn: "Id",
                  onDelete: ReferentialAction.Cascade);
          }

          protected override void Down(MigrationBuilder migrationBuilder)
          {
              migrationBuilder.DropForeignKey(
                  name: "FK_PractiseTable_Product_ProductId",
                  table: "PractiseTable");

              migrationBuilder.DropForeignKey(
                  name: "FK_Test1_Product_GetProductId",
                  table: "Test1");

              migrationBuilder.DropIndex(
                  name: "IX_PractiseTable_ProductId",
                  table: "PractiseTable");

              migrationBuilder.DropColumn(
                  name: "ProductId",
                  table: "PractiseTable");

              migrationBuilder.AlterColumn<int>(
                  name: "GetProductId",
                  table: "Test1",
                  type: "int",
                  nullable: true,
                  oldClrType: typeof(int));

              migrationBuilder.AlterColumn<int>(
                  name: "GetProductId",
                  table: "PractiseTable",
                  type: "int",
                  nullable: true,
                  oldClrType: typeof(int));

              migrationBuilder.CreateIndex(
                  name: "IX_PractiseTable_GetProductId",
                  table: "PractiseTable",
                  column: "GetProductId");

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
          }*/
        }
    }
}
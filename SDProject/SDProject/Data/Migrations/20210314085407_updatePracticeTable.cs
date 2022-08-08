using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class updatePracticeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.DropForeignKey(
                 name: "FK_PractiseTable_Product_ProductId",
                 table: "PractiseTable");

             migrationBuilder.DropIndex(
                 name: "IX_PractiseTable_ProductId",
                 table: "PractiseTable");

             migrationBuilder.DropColumn(
                 name: "ProductId",
                 table: "PractiseTable");

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
                 onDelete: ReferentialAction.Cascade);
         }

         protected override void Down(MigrationBuilder migrationBuilder)
         {
             migrationBuilder.DropForeignKey(
                 name: "FK_PractiseTable_Product_GetProductId",
                 table: "PractiseTable");

             migrationBuilder.DropIndex(
                 name: "IX_PractiseTable_GetProductId",
                 table: "PractiseTable");

             migrationBuilder.AddColumn<int>(
                 name: "ProductId",
                 table: "PractiseTable",
                 type: "int",
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
         }*/
        }
    }
}
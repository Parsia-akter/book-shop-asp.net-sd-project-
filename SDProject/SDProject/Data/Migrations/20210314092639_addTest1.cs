using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class addTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /* migrationBuilder.CreateTable(
                 name: "Test1",
                 columns: table => new
                 {
                     Id = table.Column<int>(nullable: false)
                         .Annotation("SqlServer:Identity", "1, 1"),
                     UserReview = table.Column<string>(nullable: false),
                     UserId = table.Column<string>(nullable: false),
                     GetProductId = table.Column<int>(nullable: false)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Test1", x => x.Id);
                     table.ForeignKey(
                         name: "FK_Test1_Product_GetProductId",
                         column: x => x.GetProductId,
                         principalTable: "Product",
                         principalColumn: "Id",
                         onDelete: ReferentialAction.Cascade);
                     table.ForeignKey(
                         name: "FK_Test1_AspNetUsers_UserId",
                         column: x => x.UserId,
                         principalTable: "AspNetUsers",
                         principalColumn: "Id",
                         onDelete: ReferentialAction.Cascade);
                 });

             migrationBuilder.CreateIndex(
                 name: "IX_Test1_GetProductId",
                 table: "Test1",
                 column: "GetProductId");

             migrationBuilder.CreateIndex(
                 name: "IX_Test1_UserId",
                 table: "Test1",
                 column: "UserId");
         }

         protected override void Down(MigrationBuilder migrationBuilder)
         {
             migrationBuilder.DropTable(
                 name: "Test1");
         }*/
        }
    }
}

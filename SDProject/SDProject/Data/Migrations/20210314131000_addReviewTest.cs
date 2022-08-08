using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class addReviewTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReviewTest",
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
                    table.PrimaryKey("PK_ReviewTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewTest_Product_GetProductId",
                        column: x => x.GetProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewTest_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTest_GetProductId",
                table: "ReviewTest",
                column: "GetProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTest_UserId",
                table: "ReviewTest",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewTest");
        }
    }
}

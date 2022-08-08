using Microsoft.EntityFrameworkCore.Migrations;

namespace SDProject.Data.Migrations
{
    public partial class updateReview1Again11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review1_AspNetUsers_UserId",
                table: "Review1");

            migrationBuilder.DropIndex(
                name: "IX_Review1_UserId",
                table: "Review1");

            migrationBuilder.DropColumn(
                name: "GetUserId",
                table: "Review1");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Review1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GetUserId",
                table: "Review1",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Review1",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review1_UserId",
                table: "Review1",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review1_AspNetUsers_UserId",
                table: "Review1",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

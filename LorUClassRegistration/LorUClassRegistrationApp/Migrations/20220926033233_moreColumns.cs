using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class moreColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "teacherId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_teacherId",
                table: "Classes",
                column: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_teacherId",
                table: "Classes",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "teacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_teacherId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_teacherId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "teacherId",
                table: "Classes");
        }
    }
}

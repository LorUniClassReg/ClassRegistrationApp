using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class ThisTimeIhaveFaith : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "storedId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "storedId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "storedId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "storedId",
                table: "Admins");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "storedId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "storedId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "storedId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "storedId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

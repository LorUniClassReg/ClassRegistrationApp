using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class HopefullyItWorks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "storedId",
                table: "Teachers",
                newName: "bannerId");

            migrationBuilder.RenameColumn(
                name: "storedId",
                table: "Students",
                newName: "bannerId");

            migrationBuilder.RenameColumn(
                name: "storedId",
                table: "Admins",
                newName: "bannerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bannerId",
                table: "Teachers",
                newName: "storedId");

            migrationBuilder.RenameColumn(
                name: "bannerId",
                table: "Students",
                newName: "storedId");

            migrationBuilder.RenameColumn(
                name: "bannerId",
                table: "Admins",
                newName: "storedId");
        }
    }
}

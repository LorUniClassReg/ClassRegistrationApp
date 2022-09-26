using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class PressingForward : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_HumanBeings_TeacherstoredId",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "bannerId",
                table: "Teachers",
                newName: "storedId");

            migrationBuilder.RenameColumn(
                name: "bannerId",
                table: "Students",
                newName: "storedId");

            migrationBuilder.RenameColumn(
                name: "TeacherstoredId",
                table: "Classes",
                newName: "TeacherInstancestoredId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_TeacherstoredId",
                table: "Classes",
                newName: "IX_Classes_TeacherInstancestoredId");

            migrationBuilder.RenameColumn(
                name: "bannerId",
                table: "Admins",
                newName: "storedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_HumanBeings_TeacherInstancestoredId",
                table: "Classes",
                column: "TeacherInstancestoredId",
                principalTable: "HumanBeings",
                principalColumn: "storedId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_HumanBeings_TeacherInstancestoredId",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "storedId",
                table: "Teachers",
                newName: "bannerId");

            migrationBuilder.RenameColumn(
                name: "storedId",
                table: "Students",
                newName: "bannerId");

            migrationBuilder.RenameColumn(
                name: "TeacherInstancestoredId",
                table: "Classes",
                newName: "TeacherstoredId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_TeacherInstancestoredId",
                table: "Classes",
                newName: "IX_Classes_TeacherstoredId");

            migrationBuilder.RenameColumn(
                name: "storedId",
                table: "Admins",
                newName: "bannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_HumanBeings_TeacherstoredId",
                table: "Classes",
                column: "TeacherstoredId",
                principalTable: "HumanBeings",
                principalColumn: "storedId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

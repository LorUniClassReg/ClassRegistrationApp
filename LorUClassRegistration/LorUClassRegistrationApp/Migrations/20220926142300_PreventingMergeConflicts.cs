using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class PreventingMergeConflicts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_HumanBeings_TeacherInstancestoredId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_teacherId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_teacherId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "teacherId",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "TeacherInstancestoredId",
                table: "Classes",
                newName: "TeacherInstanceteacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_TeacherInstancestoredId",
                table: "Classes",
                newName: "IX_Classes_TeacherInstanceteacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TeacherInstanceteacherId",
                table: "Classes",
                column: "TeacherInstanceteacherId",
                principalTable: "Teachers",
                principalColumn: "teacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherInstanceteacherId",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "TeacherInstanceteacherId",
                table: "Classes",
                newName: "TeacherInstancestoredId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_TeacherInstanceteacherId",
                table: "Classes",
                newName: "IX_Classes_TeacherInstancestoredId");

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
                name: "FK_Classes_HumanBeings_TeacherInstancestoredId",
                table: "Classes",
                column: "TeacherInstancestoredId",
                principalTable: "HumanBeings",
                principalColumn: "storedId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_teacherId",
                table: "Classes",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "teacherId");
        }
    }
}

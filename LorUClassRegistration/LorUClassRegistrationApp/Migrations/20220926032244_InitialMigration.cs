using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanBeings",
                columns: table => new
                {
                    storedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bannerId = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    legalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    actualName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isStudent = table.Column<bool>(type: "bit", nullable: false),
                    isTeacher = table.Column<bool>(type: "bit", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    isHyperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    isLor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanBeings", x => x.storedId);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storedId = table.Column<int>(type: "int", nullable: false),
                    AdminInstancestoredId = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yearsWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminId);
                    table.ForeignKey(
                        name: "FK_Admins_HumanBeings_AdminInstancestoredId",
                        column: x => x.AdminInstancestoredId,
                        principalTable: "HumanBeings",
                        principalColumn: "storedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lors",
                columns: table => new
                {
                    lorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storedId = table.Column<int>(type: "int", nullable: false),
                    LorInTheFleshstoredId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lors", x => x.lorId);
                    table.ForeignKey(
                        name: "FK_Lors_HumanBeings_LorInTheFleshstoredId",
                        column: x => x.LorInTheFleshstoredId,
                        principalTable: "HumanBeings",
                        principalColumn: "storedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storedId = table.Column<int>(type: "int", nullable: false),
                    StudentInstancestoredId = table.Column<int>(type: "int", nullable: false),
                    major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semestersCompleted = table.Column<int>(type: "int", nullable: false),
                    dateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projectedGraduation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maxCredits = table.Column<int>(type: "int", nullable: false),
                    creditsCompleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentId);
                    table.ForeignKey(
                        name: "FK_Students_HumanBeings_StudentInstancestoredId",
                        column: x => x.StudentInstancestoredId,
                        principalTable: "HumanBeings",
                        principalColumn: "storedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storedId = table.Column<int>(type: "int", nullable: false),
                    TeacherInstancestoredId = table.Column<int>(type: "int", nullable: false),
                    Dept = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classQty = table.Column<int>(type: "int", nullable: false),
                    dateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yearsWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_HumanBeings_TeacherInstancestoredId",
                        column: x => x.TeacherInstancestoredId,
                        principalTable: "HumanBeings",
                        principalColumn: "storedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    classId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept = table.Column<int>(type: "int", nullable: false),
                    preReqId = table.Column<int>(type: "int", nullable: true),
                    PreReqsclassId = table.Column<int>(type: "int", nullable: true),
                    storedId = table.Column<int>(type: "int", nullable: false),
                    TeacherstoredId = table.Column<int>(type: "int", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    section = table.Column<int>(type: "int", nullable: false),
                    courseTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creditHours = table.Column<double>(type: "float", nullable: false),
                    classDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.classId);
                    table.ForeignKey(
                        name: "FK_Classes_Classes_PreReqsclassId",
                        column: x => x.PreReqsclassId,
                        principalTable: "Classes",
                        principalColumn: "classId");
                    table.ForeignKey(
                        name: "FK_Classes_HumanBeings_TeacherstoredId",
                        column: x => x.TeacherstoredId,
                        principalTable: "HumanBeings",
                        principalColumn: "storedId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "studentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminInstancestoredId",
                table: "Admins",
                column: "AdminInstancestoredId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_PreReqsclassId",
                table: "Classes",
                column: "PreReqsclassId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_studentId",
                table: "Classes",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherstoredId",
                table: "Classes",
                column: "TeacherstoredId");

            migrationBuilder.CreateIndex(
                name: "IX_Lors_LorInTheFleshstoredId",
                table: "Lors",
                column: "LorInTheFleshstoredId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentInstancestoredId",
                table: "Students",
                column: "StudentInstancestoredId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherInstancestoredId",
                table: "Teachers",
                column: "TeacherInstancestoredId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Lors");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "HumanBeings");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class InitialDbSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bannerFk = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yearsWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    classId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentFk = table.Column<int>(type: "int", nullable: false),
                    preReqs = table.Column<int>(type: "int", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    section = table.Column<int>(type: "int", nullable: false),
                    courseTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creditHours = table.Column<double>(type: "float", nullable: false),
                    classDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.classId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    deptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.deptId);
                });

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
                name: "Lors",
                columns: table => new
                {
                    lorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bannerFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lors", x => x.lorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bannerFk = table.Column<int>(type: "int", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bannerFk = table.Column<int>(type: "int", nullable: false),
                    deptFk = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classQty = table.Column<int>(type: "int", nullable: false),
                    dateStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    yearsWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "HumanBeings");

            migrationBuilder.DropTable(
                name: "Lors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}

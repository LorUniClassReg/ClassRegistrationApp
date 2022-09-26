using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class seedingAndFixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lors");

            migrationBuilder.AlterColumn<int>(
                name: "classDays",
                table: "Classes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "classDays",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Lors",
                columns: table => new
                {
                    lorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LorInTheFleshstoredId = table.Column<int>(type: "int", nullable: false),
                    storedId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Lors_LorInTheFleshstoredId",
                table: "Lors",
                column: "LorInTheFleshstoredId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    public partial class MoreandMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "preReqId",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "preReqId",
                table: "Classes",
                type: "int",
                nullable: true);
        }
    }
}

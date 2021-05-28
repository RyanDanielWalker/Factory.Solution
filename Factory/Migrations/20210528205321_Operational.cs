using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Operational : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Operational",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operational",
                table: "Machines");
        }
    }
}

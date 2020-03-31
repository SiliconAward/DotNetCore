using Microsoft.EntityFrameworkCore.Migrations;

namespace SiliconAward.Migrations
{
    public partial class CustomlogDropMessage3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message3",
                table: "CustomLogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message3",
                table: "CustomLogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

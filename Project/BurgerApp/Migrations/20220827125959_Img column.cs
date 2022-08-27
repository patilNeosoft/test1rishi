using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.Migrations
{
    public partial class Imgcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Burgers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Burgers");
        }
    }
}

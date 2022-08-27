using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.Migrations
{
    public partial class imgincartandbuy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Buy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Buy");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Burger",
                table: "Burger");

            migrationBuilder.RenameTable(
                name: "Burger",
                newName: "Burgers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Burgers",
                table: "Burgers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Burger_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Burger_Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Burgers",
                table: "Burgers");

            migrationBuilder.RenameTable(
                name: "Burgers",
                newName: "Burger");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Burger",
                table: "Burger",
                column: "Id");
        }
    }
}

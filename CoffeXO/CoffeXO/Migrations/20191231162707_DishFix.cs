using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeXO.Migrations
{
    public partial class DishFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Sale",
                table: "Dishes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sale",
                table: "Dishes",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}

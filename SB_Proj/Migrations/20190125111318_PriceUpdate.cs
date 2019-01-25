using Microsoft.EntityFrameworkCore.Migrations;

namespace SB_Proj.Migrations
{
    public partial class PriceUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                nullable: false,
                oldClrType: typeof(double));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Book",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}

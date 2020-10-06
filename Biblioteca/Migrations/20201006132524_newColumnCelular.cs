using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class newColumnCelular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "celular",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "celular",
                table: "Cliente");
        }
    }
}

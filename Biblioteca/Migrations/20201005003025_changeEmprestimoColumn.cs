using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class changeEmprestimoColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "devolvidoEm",
                table: "Emprestimo");

            migrationBuilder.AddColumn<bool>(
                name: "devolvido",
                table: "Emprestimo",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "devolvido",
                table: "Emprestimo");

            migrationBuilder.AddColumn<DateTime>(
                name: "devolvidoEm",
                table: "Emprestimo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

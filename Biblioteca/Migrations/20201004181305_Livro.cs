using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class Livro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Funcionario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "Id");

          

           

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    titulo = table.Column<string>(nullable: true),
                    autor = table.Column<string>(nullable: true),
                    genero = table.Column<string>(nullable: true),
                    isbn = table.Column<string>(nullable: true),
                    ano = table.Column<string>(nullable: true),
                    editora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Funcionario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "id");
        }
    }
}

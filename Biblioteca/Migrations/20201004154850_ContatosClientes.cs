using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class ContatosClientes : Migration
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Funcionario",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Cliente",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ContatosCliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    telefone = table.Column<int>(nullable: false),
                    clienteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContatosCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContatosCliente_Cliente_clienteId",
                        column: x => x.clienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContatosCliente_clienteId",
                table: "ContatosCliente",
                column: "clienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContatosCliente");

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

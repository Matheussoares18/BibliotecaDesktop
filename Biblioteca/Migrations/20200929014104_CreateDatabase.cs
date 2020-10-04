using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<string>(nullable: true),
<<<<<<< HEAD
=======
       
>>>>>>> b53d387c8f5eb1052e5c1bd8ebfddb377e5970d5
                    email = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(nullable: true),
                    dateBirth = table.Column<DateTime>(nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}

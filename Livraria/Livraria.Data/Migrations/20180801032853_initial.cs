using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    IdGenero = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    GeneroIdGenero = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_livro_genero_GeneroIdGenero",
                        column: x => x.GeneroIdGenero,
                        principalTable: "genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_livro_GeneroIdGenero",
                table: "livro",
                column: "GeneroIdGenero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livro");

            migrationBuilder.DropTable(
                name: "genero");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.Migrations
{
    public partial class AddCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Noticias",
                table: "Noticias");

            migrationBuilder.RenameTable(
                name: "Noticias",
                newName: "Noticia");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Noticia",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fuente",
                table: "Noticia",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Noticia",
                table: "Noticia",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Noticia_CategoriaId",
                table: "Noticia",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Noticia_Categoria_CategoriaId",
                table: "Noticia",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noticia_Categoria_CategoriaId",
                table: "Noticia");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Noticia",
                table: "Noticia");

            migrationBuilder.DropIndex(
                name: "IX_Noticia_CategoriaId",
                table: "Noticia");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Noticia");

            migrationBuilder.DropColumn(
                name: "Fuente",
                table: "Noticia");

            migrationBuilder.RenameTable(
                name: "Noticia",
                newName: "Noticias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Noticias",
                table: "Noticias",
                column: "ID");
        }
    }
}

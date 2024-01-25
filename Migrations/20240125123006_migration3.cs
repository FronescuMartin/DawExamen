using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Editura_Edituraid",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Editura_Edituraid",
                table: "Carte");

            migrationBuilder.RenameColumn(
                name: "Edituraid",
                table: "Carte",
                newName: "edituraid");

            migrationBuilder.RenameIndex(
                name: "IX_Carte_Edituraid",
                table: "Carte",
                newName: "IX_Carte_edituraid");

            migrationBuilder.RenameColumn(
                name: "Edituraid",
                table: "Autor",
                newName: "edituraid");

            migrationBuilder.RenameIndex(
                name: "IX_Autor_Edituraid",
                table: "Autor",
                newName: "IX_Autor_edituraid");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Editura_edituraid",
                table: "Autor",
                column: "edituraid",
                principalTable: "Editura",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Editura_edituraid",
                table: "Carte",
                column: "edituraid",
                principalTable: "Editura",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Editura_edituraid",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Editura_edituraid",
                table: "Carte");

            migrationBuilder.RenameColumn(
                name: "edituraid",
                table: "Carte",
                newName: "Edituraid");

            migrationBuilder.RenameIndex(
                name: "IX_Carte_edituraid",
                table: "Carte",
                newName: "IX_Carte_Edituraid");

            migrationBuilder.RenameColumn(
                name: "edituraid",
                table: "Autor",
                newName: "Edituraid");

            migrationBuilder.RenameIndex(
                name: "IX_Autor_edituraid",
                table: "Autor",
                newName: "IX_Autor_Edituraid");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Editura_Edituraid",
                table: "Autor",
                column: "Edituraid",
                principalTable: "Editura",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Editura_Edituraid",
                table: "Carte",
                column: "Edituraid",
                principalTable: "Editura",
                principalColumn: "id");
        }
    }
}

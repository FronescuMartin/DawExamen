using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Editura_edituraid",
                table: "Autor");

            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Editura_edituraid",
                table: "Carte");

            migrationBuilder.DropIndex(
                name: "IX_Carte_edituraid",
                table: "Carte");

            migrationBuilder.DropIndex(
                name: "IX_Autor_edituraid",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "editura_id",
                table: "Carte");

            migrationBuilder.DropColumn(
                name: "edituraid",
                table: "Carte");

            migrationBuilder.DropColumn(
                name: "editura_id",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "edituraid",
                table: "Autor");

            migrationBuilder.AddColumn<int>(
                name: "autor_id",
                table: "Editura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "autorid",
                table: "Editura",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "carte_id",
                table: "Editura",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "carteid",
                table: "Editura",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Editura_autorid",
                table: "Editura",
                column: "autorid");

            migrationBuilder.CreateIndex(
                name: "IX_Editura_carteid",
                table: "Editura",
                column: "carteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Editura_Autor_autorid",
                table: "Editura",
                column: "autorid",
                principalTable: "Autor",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Editura_Carte_carteid",
                table: "Editura",
                column: "carteid",
                principalTable: "Carte",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Editura_Autor_autorid",
                table: "Editura");

            migrationBuilder.DropForeignKey(
                name: "FK_Editura_Carte_carteid",
                table: "Editura");

            migrationBuilder.DropIndex(
                name: "IX_Editura_autorid",
                table: "Editura");

            migrationBuilder.DropIndex(
                name: "IX_Editura_carteid",
                table: "Editura");

            migrationBuilder.DropColumn(
                name: "autor_id",
                table: "Editura");

            migrationBuilder.DropColumn(
                name: "autorid",
                table: "Editura");

            migrationBuilder.DropColumn(
                name: "carte_id",
                table: "Editura");

            migrationBuilder.DropColumn(
                name: "carteid",
                table: "Editura");

            migrationBuilder.AddColumn<int>(
                name: "editura_id",
                table: "Carte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "edituraid",
                table: "Carte",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "editura_id",
                table: "Autor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "edituraid",
                table: "Autor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carte_edituraid",
                table: "Carte",
                column: "edituraid");

            migrationBuilder.CreateIndex(
                name: "IX_Autor_edituraid",
                table: "Autor",
                column: "edituraid");

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
    }
}

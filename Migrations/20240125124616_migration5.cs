using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Autor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "edituraid",
                table: "Autor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publicatie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carteid = table.Column<int>(type: "int", nullable: true),
                    carte_id = table.Column<int>(type: "int", nullable: false),
                    autorid = table.Column<int>(type: "int", nullable: true),
                    autor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicatie", x => x.id);
                    table.ForeignKey(
                        name: "FK_Publicatie_Autor_autorid",
                        column: x => x.autorid,
                        principalTable: "Autor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Publicatie_Carte_carteid",
                        column: x => x.carteid,
                        principalTable: "Carte",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_edituraid",
                table: "Autor",
                column: "edituraid");

            migrationBuilder.CreateIndex(
                name: "IX_Publicatie_autorid",
                table: "Publicatie",
                column: "autorid");

            migrationBuilder.CreateIndex(
                name: "IX_Publicatie_carteid",
                table: "Publicatie",
                column: "carteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Editura_edituraid",
                table: "Autor",
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

            migrationBuilder.DropTable(
                name: "Publicatie");

            migrationBuilder.DropIndex(
                name: "IX_Autor_edituraid",
                table: "Autor");

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
    }
}

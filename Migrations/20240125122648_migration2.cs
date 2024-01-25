using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examen.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Edituraid",
                table: "Autor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Editura",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Carte",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    editura_id = table.Column<int>(type: "int", nullable: false),
                    Edituraid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carte", x => x.id);
                    table.ForeignKey(
                        name: "FK_Carte_Editura_Edituraid",
                        column: x => x.Edituraid,
                        principalTable: "Editura",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autor_Edituraid",
                table: "Autor",
                column: "Edituraid");

            migrationBuilder.CreateIndex(
                name: "IX_Carte_Edituraid",
                table: "Carte",
                column: "Edituraid");

            migrationBuilder.AddForeignKey(
                name: "FK_Autor_Editura_Edituraid",
                table: "Autor",
                column: "Edituraid",
                principalTable: "Editura",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autor_Editura_Edituraid",
                table: "Autor");

            migrationBuilder.DropTable(
                name: "Carte");

            migrationBuilder.DropTable(
                name: "Editura");

            migrationBuilder.DropIndex(
                name: "IX_Autor_Edituraid",
                table: "Autor");

            migrationBuilder.DropColumn(
                name: "Edituraid",
                table: "Autor");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AjoutDonnéesJeux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Jeux",
                columns: table => new
                {
                    IdJeux = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Jeux", x => x.IdJeux);
                });

            migrationBuilder.InsertData(
                table: "T_Jeux",
                columns: new[] { "IdJeux", "Nom", "Score" },
                values: new object[] { 3, "Deep Rock Galactic", 9.0 });

            migrationBuilder.InsertData(
                table: "T_Jeux",
                columns: new[] { "IdJeux", "Nom", "Score" },
                values: new object[] { 5, "Pacman", 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Jeux");
        }
    }
}

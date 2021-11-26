using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AjoutDesRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JeuxJoueur",
                columns: table => new
                {
                    IdJoueur = table.Column<int>(type: "int", nullable: false),
                    IdJeux = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JeuxJoueur", x => new { x.IdJeux, x.IdJoueur });
                    table.ForeignKey(
                        name: "FK_JeuxJoueur_T_Jeux_IdJeux",
                        column: x => x.IdJeux,
                        principalTable: "T_Jeux",
                        principalColumn: "IdJeux",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JeuxJoueur_T_Joueur_IdJoueur",
                        column: x => x.IdJoueur,
                        principalTable: "T_Joueur",
                        principalColumn: "IdJoueur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JeuxJoueur_IdJoueur",
                table: "JeuxJoueur",
                column: "IdJoueur");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JeuxJoueur");
        }
    }
}

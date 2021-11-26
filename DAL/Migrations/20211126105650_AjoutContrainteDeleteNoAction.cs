using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AjoutContrainteDeleteNoAction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JeuxJoueur_T_Jeux_IdJeux",
                table: "JeuxJoueur");

            migrationBuilder.DropForeignKey(
                name: "FK_JeuxJoueur_T_Joueur_IdJoueur",
                table: "JeuxJoueur");

            migrationBuilder.AddForeignKey(
                name: "FK_JeuxJoueur_T_Jeux_IdJeux",
                table: "JeuxJoueur",
                column: "IdJeux",
                principalTable: "T_Jeux",
                principalColumn: "IdJeux");

            migrationBuilder.AddForeignKey(
                name: "FK_JeuxJoueur_T_Joueur_IdJoueur",
                table: "JeuxJoueur",
                column: "IdJoueur",
                principalTable: "T_Joueur",
                principalColumn: "IdJoueur");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JeuxJoueur_T_Jeux_IdJeux",
                table: "JeuxJoueur");

            migrationBuilder.DropForeignKey(
                name: "FK_JeuxJoueur_T_Joueur_IdJoueur",
                table: "JeuxJoueur");

            migrationBuilder.AddForeignKey(
                name: "FK_JeuxJoueur_T_Jeux_IdJeux",
                table: "JeuxJoueur",
                column: "IdJeux",
                principalTable: "T_Jeux",
                principalColumn: "IdJeux",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JeuxJoueur_T_Joueur_IdJoueur",
                table: "JeuxJoueur",
                column: "IdJoueur",
                principalTable: "T_Joueur",
                principalColumn: "IdJoueur",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

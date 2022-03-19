using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFEDal.Migrations
{
    public partial class CreatRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Utilisateurs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "UderId",
                table: "Utilisateurs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Commande_Sorties",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Commande_Sorties",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Commande_Sorties",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UtilisateurUderId",
                table: "Commande_Sorties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Command_Entrees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FournisseurId_f",
                table: "Command_Entrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_f",
                table: "Command_Entrees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Command_Entrees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UtilisateurUderId",
                table: "Command_Entrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs",
                column: "UderId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_Sorties_ArticleId",
                table: "Commande_Sorties",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_Sorties_ClientId",
                table: "Commande_Sorties",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_Sorties_UtilisateurUderId",
                table: "Commande_Sorties",
                column: "UtilisateurUderId");

            migrationBuilder.CreateIndex(
                name: "IX_Command_Entrees_ArticleId",
                table: "Command_Entrees",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Command_Entrees_FournisseurId_f",
                table: "Command_Entrees",
                column: "FournisseurId_f");

            migrationBuilder.CreateIndex(
                name: "IX_Command_Entrees_UtilisateurUderId",
                table: "Command_Entrees",
                column: "UtilisateurUderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_Entrees_Articles_ArticleId",
                table: "Command_Entrees",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Command_Entrees_fournisseurs_FournisseurId_f",
                table: "Command_Entrees",
                column: "FournisseurId_f",
                principalTable: "fournisseurs",
                principalColumn: "Id_f",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Command_Entrees_Utilisateurs_UtilisateurUderId",
                table: "Command_Entrees",
                column: "UtilisateurUderId",
                principalTable: "Utilisateurs",
                principalColumn: "UderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Sorties_Articles_ArticleId",
                table: "Commande_Sorties",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Sorties_clients_ClientId",
                table: "Commande_Sorties",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Sorties_Utilisateurs_UtilisateurUderId",
                table: "Commande_Sorties",
                column: "UtilisateurUderId",
                principalTable: "Utilisateurs",
                principalColumn: "UderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Command_Entrees_Articles_ArticleId",
                table: "Command_Entrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Command_Entrees_fournisseurs_FournisseurId_f",
                table: "Command_Entrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Command_Entrees_Utilisateurs_UtilisateurUderId",
                table: "Command_Entrees");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Sorties_Articles_ArticleId",
                table: "Commande_Sorties");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Sorties_clients_ClientId",
                table: "Commande_Sorties");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Sorties_Utilisateurs_UtilisateurUderId",
                table: "Commande_Sorties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs");

            migrationBuilder.DropIndex(
                name: "IX_Commande_Sorties_ArticleId",
                table: "Commande_Sorties");

            migrationBuilder.DropIndex(
                name: "IX_Commande_Sorties_ClientId",
                table: "Commande_Sorties");

            migrationBuilder.DropIndex(
                name: "IX_Commande_Sorties_UtilisateurUderId",
                table: "Commande_Sorties");

            migrationBuilder.DropIndex(
                name: "IX_Command_Entrees_ArticleId",
                table: "Command_Entrees");

            migrationBuilder.DropIndex(
                name: "IX_Command_Entrees_FournisseurId_f",
                table: "Command_Entrees");

            migrationBuilder.DropIndex(
                name: "IX_Command_Entrees_UtilisateurUderId",
                table: "Command_Entrees");

            migrationBuilder.DropColumn(
                name: "UderId",
                table: "Utilisateurs");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Commande_Sorties");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Commande_Sorties");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Commande_Sorties");

            migrationBuilder.DropColumn(
                name: "UtilisateurUderId",
                table: "Commande_Sorties");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Command_Entrees");

            migrationBuilder.DropColumn(
                name: "FournisseurId_f",
                table: "Command_Entrees");

            migrationBuilder.DropColumn(
                name: "Id_f",
                table: "Command_Entrees");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Command_Entrees");

            migrationBuilder.DropColumn(
                name: "UtilisateurUderId",
                table: "Command_Entrees");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Utilisateurs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs",
                column: "Login");
        }
    }
}

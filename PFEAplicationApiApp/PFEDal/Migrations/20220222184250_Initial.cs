using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PFEDal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Famille = table.Column<int>(type: "int", nullable: false),
                    Prix = table.Column<int>(type: "int", nullable: false),
                    QTE_Stock = table.Column<int>(type: "int", nullable: false),
                    QET_Min = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientTel = table.Column<int>(type: "int", nullable: false),
                    ClientEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientFax = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Command_Entrees",
                columns: table => new
                {
                    Id_Bon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Com = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Command_Entrees", x => x.Id_Bon);
                });

            migrationBuilder.CreateTable(
                name: "Commande_Sorties",
                columns: table => new
                {
                    Id_Com = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref_com = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_com = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande_Sorties", x => x.Id_Com);
                });

            migrationBuilder.CreateTable(
                name: "factures",
                columns: table => new
                {
                    Id_fa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_fa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ref_fa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factures", x => x.Id_fa);
                });

            migrationBuilder.CreateTable(
                name: "fournisseurs",
                columns: table => new
                {
                    Id_f = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress_f = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel_f = table.Column<int>(type: "int", nullable: false),
                    Fax_f = table.Column<int>(type: "int", nullable: false),
                    Email_f = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fournisseurs", x => x.Id_f);
                });

            migrationBuilder.CreateTable(
                name: "Lig_Com_Entrees",
                columns: table => new
                {
                    Id_Bomc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QTE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lig_Com_Entrees", x => x.Id_Bomc);
                });

            migrationBuilder.CreateTable(
                name: "Lig_Com_Sorties",
                columns: table => new
                {
                    Id_Bon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prix_A = table.Column<int>(type: "int", nullable: false),
                    QTE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lig_Com_Sorties", x => x.Id_Bon);
                });

            migrationBuilder.CreateTable(
                name: "liv_Entrees",
                columns: table => new
                {
                    Id_BonL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref_liv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solde = table.Column<int>(type: "int", nullable: false),
                    Date_BonL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liv_Entrees", x => x.Id_BonL);
                });

            migrationBuilder.CreateTable(
                name: "liv_Sorties",
                columns: table => new
                {
                    Id_Liv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Liv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Liv_Ref = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liv_Sorties", x => x.Id_Liv);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateConxion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Naiss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Login);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "Command_Entrees");

            migrationBuilder.DropTable(
                name: "Commande_Sorties");

            migrationBuilder.DropTable(
                name: "factures");

            migrationBuilder.DropTable(
                name: "fournisseurs");

            migrationBuilder.DropTable(
                name: "Lig_Com_Entrees");

            migrationBuilder.DropTable(
                name: "Lig_Com_Sorties");

            migrationBuilder.DropTable(
                name: "liv_Entrees");

            migrationBuilder.DropTable(
                name: "liv_Sorties");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Utilisateurs");
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PFEDal.Modeles;

#nullable disable

namespace PFEDal.Migrations
{
    [DbContext(typeof(PfeDbContext))]
    [Migration("20220301234751_DeletColoun")]
    partial class DeletColoun
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PFEDal.Modeles.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"), 1L, 1);

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Famille")
                        .HasColumnType("int");

                    b.Property<int>("Prix")
                        .HasColumnType("int");

                    b.Property<int>("QET_Min")
                        .HasColumnType("int");

                    b.Property<int>("QTE_Stock")
                        .HasColumnType("int");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("PFEDal.Modeles.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("ClientAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientFax")
                        .HasColumnType("int");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientTel")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("PFEDal.Modeles.Command_Entree", b =>
                {
                    b.Property<int>("Id_Bon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Bon"), 1L, 1);

                    b.Property<string>("Date_Com")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Bon");

                    b.ToTable("Command_Entrees");
                });

            modelBuilder.Entity("PFEDal.Modeles.Commande_Sortie", b =>
                {
                    b.Property<int>("Id_Com")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Com"), 1L, 1);

                    b.Property<string>("Date_com")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ref_com")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Com");

                    b.ToTable("Commande_Sorties");
                });

            modelBuilder.Entity("PFEDal.Modeles.Facture", b =>
                {
                    b.Property<int>("Id_fa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_fa"), 1L, 1);

                    b.Property<string>("Date_fa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ref_fa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_fa");

                    b.ToTable("factures");
                });

            modelBuilder.Entity("PFEDal.Modeles.Fournisseur", b =>
                {
                    b.Property<int>("Id_f")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_f"), 1L, 1);

                    b.Property<string>("Adress_f")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email_f")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fax_f")
                        .HasColumnType("int");

                    b.Property<string>("Name_f")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tel_f")
                        .HasColumnType("int");

                    b.HasKey("Id_f");

                    b.ToTable("fournisseurs");
                });

            modelBuilder.Entity("PFEDal.Modeles.Lig_Com_Entree", b =>
                {
                    b.Property<int>("Id_Bomc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Bomc"), 1L, 1);

                    b.Property<int>("QTE")
                        .HasColumnType("int");

                    b.HasKey("Id_Bomc");

                    b.ToTable("Lig_Com_Entrees");
                });

            modelBuilder.Entity("PFEDal.Modeles.Lig_Com_Sortie", b =>
                {
                    b.Property<int>("Id_Bon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Bon"), 1L, 1);

                    b.Property<int>("Prix_A")
                        .HasColumnType("int");

                    b.Property<int>("QTE")
                        .HasColumnType("int");

                    b.HasKey("Id_Bon");

                    b.ToTable("Lig_Com_Sorties");
                });

            modelBuilder.Entity("PFEDal.Modeles.Liv_Entree", b =>
                {
                    b.Property<int>("Id_BonL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_BonL"), 1L, 1);

                    b.Property<string>("Date_BonL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ref_liv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Solde")
                        .HasColumnType("int");

                    b.HasKey("Id_BonL");

                    b.ToTable("liv_Entrees");
                });

            modelBuilder.Entity("PFEDal.Modeles.Liv_Sortie", b =>
                {
                    b.Property<int>("Id_Liv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Liv"), 1L, 1);

                    b.Property<string>("Date_Liv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Liv_Ref")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Liv");

                    b.ToTable("liv_Sorties");
                });

            modelBuilder.Entity("PFEDal.Modeles.Session", b =>
                {
                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateConxion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SessionId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("PFEDal.Modeles.Utilisateur", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date_Naiss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tel")
                        .HasColumnType("int");

                    b.HasKey("Login");

                    b.ToTable("Utilisateurs");
                });
#pragma warning restore 612, 618
        }
    }
}

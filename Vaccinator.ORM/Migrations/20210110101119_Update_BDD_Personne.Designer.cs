﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vaccinator.ORM;

namespace Vaccinator.ORM.Migrations
{
    [DbContext(typeof(Contexte))]
    [Migration("20210110101119_Update_BDD_Personne")]
    partial class Update_BDD_Personne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Vaccinator.ORM.Injection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateRappel")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marque")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("NuméroDuLot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonneId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypesVaccinId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PersonneId");

                    b.HasIndex("TypesVaccinId");

                    b.ToTable("Injections");
                });

            modelBuilder.Entity("Vaccinator.ORM.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateDeNaissance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Résident_Ou_Personnel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SexeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SexeId");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("Vaccinator.ORM.Sexe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sexes");
                });

            modelBuilder.Entity("Vaccinator.ORM.TypesVaccin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TypesVaccins");
                });

            modelBuilder.Entity("Vaccinator.ORM.Injection", b =>
                {
                    b.HasOne("Vaccinator.ORM.Personne", "personne")
                        .WithMany("Injections")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vaccinator.ORM.TypesVaccin", "TypesVaccins")
                        .WithMany("Injections")
                        .HasForeignKey("TypesVaccinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("personne");

                    b.Navigation("TypesVaccins");
                });

            modelBuilder.Entity("Vaccinator.ORM.Personne", b =>
                {
                    b.HasOne("Vaccinator.ORM.Sexe", "sexe")
                        .WithMany("personnes")
                        .HasForeignKey("SexeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sexe");
                });

            modelBuilder.Entity("Vaccinator.ORM.Personne", b =>
                {
                    b.Navigation("Injections");
                });

            modelBuilder.Entity("Vaccinator.ORM.Sexe", b =>
                {
                    b.Navigation("personnes");
                });

            modelBuilder.Entity("Vaccinator.ORM.TypesVaccin", b =>
                {
                    b.Navigation("Injections");
                });
#pragma warning restore 612, 618
        }
    }
}

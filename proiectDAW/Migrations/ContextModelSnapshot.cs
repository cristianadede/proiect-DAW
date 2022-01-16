﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proiectDAW.Data;

namespace proiectDAW.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("proiectDAW.Models.DataBaseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Titlu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataBaseModels");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Varsta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.ActorFilm", b =>
                {
                    b.Property<Guid>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FilmId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("ActorFilms");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Comentariu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mesaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UtilizatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UtilizatorId");

                    b.ToTable("Comentarius");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Film", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DetaliuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Limba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titlu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetaliuId")
                        .IsUnique();

                    b.HasIndex("GenId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Model3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Models3");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Model4", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Models4");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.ModelLegatura", b =>
                {
                    b.Property<Guid>("Model3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Model4Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Model3Id", "Model4Id");

                    b.HasIndex("Model4Id");

                    b.ToTable("ModelLegaturas");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Utilizator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilizators");
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_Many.Gen", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeGen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gens");
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_Many.Model1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models1");
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_Many.Model2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Model1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Model1Id");

                    b.ToTable("Models2");
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_One.Detaliu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Durata")
                        .HasColumnType("int");

                    b.Property<Guid>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Detalius");
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_One.Model5", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models5");
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_One.Model6", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCreare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificare")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Model5Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Model5Id")
                        .IsUnique();

                    b.ToTable("Models6");
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.ActorFilm", b =>
                {
                    b.HasOne("proiectDAW.Models.Many_to_Many.Actor", "Actor")
                        .WithMany("ActorFilms")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiectDAW.Models.Many_to_Many.Film", "Film")
                        .WithMany("ActorFilms")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Comentariu", b =>
                {
                    b.HasOne("proiectDAW.Models.Many_to_Many.Film", "Film")
                        .WithMany("Comentarius")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiectDAW.Models.Many_to_Many.Utilizator", "Utilizator")
                        .WithMany("Comentarius")
                        .HasForeignKey("UtilizatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.Film", b =>
                {
                    b.HasOne("proiectDAW.Models.One_to_One.Detaliu", "Detaliu")
                        .WithOne("Film")
                        .HasForeignKey("proiectDAW.Models.Many_to_Many.Film", "DetaliuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiectDAW.Models.One_to_Many.Gen", "Gen")
                        .WithMany("Films")
                        .HasForeignKey("GenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proiectDAW.Models.Many_to_Many.ModelLegatura", b =>
                {
                    b.HasOne("proiectDAW.Models.Many_to_Many.Model3", "Model3")
                        .WithMany("ModelLegaturas")
                        .HasForeignKey("Model3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiectDAW.Models.Many_to_Many.Model4", "Model4")
                        .WithMany("ModelLegaturas")
                        .HasForeignKey("Model4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_Many.Model2", b =>
                {
                    b.HasOne("proiectDAW.Models.One_to_Many.Model1", "Model1")
                        .WithMany("Models2")
                        .HasForeignKey("Model1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("proiectDAW.Models.One_to_One.Model6", b =>
                {
                    b.HasOne("proiectDAW.Models.One_to_One.Model5", "Model5")
                        .WithOne("Model6")
                        .HasForeignKey("proiectDAW.Models.One_to_One.Model6", "Model5Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

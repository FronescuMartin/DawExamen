﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using examen.ContextModels;

#nullable disable

namespace examen.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("examen.Entities.Autor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("editura_id")
                        .HasColumnType("int");

                    b.Property<int?>("edituraid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("edituraid");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("examen.Entities.Carte", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Carte");
                });

            modelBuilder.Entity("examen.Entities.Editura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Editura");
                });

            modelBuilder.Entity("examen.Entities.Publicatie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("autor_id")
                        .HasColumnType("int");

                    b.Property<int?>("autorid")
                        .HasColumnType("int");

                    b.Property<int>("carte_id")
                        .HasColumnType("int");

                    b.Property<int?>("carteid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("autorid");

                    b.HasIndex("carteid");

                    b.ToTable("Publicatie");
                });

            modelBuilder.Entity("examen.Entities.Autor", b =>
                {
                    b.HasOne("examen.Entities.Editura", "editura")
                        .WithMany("autori")
                        .HasForeignKey("edituraid");

                    b.Navigation("editura");
                });

            modelBuilder.Entity("examen.Entities.Publicatie", b =>
                {
                    b.HasOne("examen.Entities.Autor", "autor")
                        .WithMany("Publicatii")
                        .HasForeignKey("autorid");

                    b.HasOne("examen.Entities.Carte", "carte")
                        .WithMany("Edituri")
                        .HasForeignKey("carteid");

                    b.Navigation("autor");

                    b.Navigation("carte");
                });

            modelBuilder.Entity("examen.Entities.Autor", b =>
                {
                    b.Navigation("Publicatii");
                });

            modelBuilder.Entity("examen.Entities.Carte", b =>
                {
                    b.Navigation("Edituri");
                });

            modelBuilder.Entity("examen.Entities.Editura", b =>
                {
                    b.Navigation("autori");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using examen.ContextModels;

#nullable disable

namespace examen.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20240125123006_migration3")]
    partial class migration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("editura_id")
                        .HasColumnType("int");

                    b.Property<int?>("edituraid")
                        .HasColumnType("int");

                    b.Property<string>("titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("edituraid");

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

            modelBuilder.Entity("examen.Entities.Autor", b =>
                {
                    b.HasOne("examen.Entities.Editura", "editura")
                        .WithMany("Autori")
                        .HasForeignKey("edituraid");

                    b.Navigation("editura");
                });

            modelBuilder.Entity("examen.Entities.Carte", b =>
                {
                    b.HasOne("examen.Entities.Editura", "editura")
                        .WithMany("Carti")
                        .HasForeignKey("edituraid");

                    b.Navigation("editura");
                });

            modelBuilder.Entity("examen.Entities.Editura", b =>
                {
                    b.Navigation("Autori");

                    b.Navigation("Carti");
                });
#pragma warning restore 612, 618
        }
    }
}

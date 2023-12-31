﻿// <auto-generated />
using CursoWebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CursoWebApi.Migrations
{
    [DbContext(typeof(ApplicationDBContextcs))]
    [Migration("20230721185721_AutoresLibros")]
    partial class AutoresLibros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CursoWebApi.Entidades.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("CursoWebApi.Entidades.AutorLibro", b =>
                {
                    b.Property<int>("Autorid")
                        .HasColumnType("int");

                    b.Property<int>("Libroid")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.HasKey("Autorid", "Libroid");

                    b.HasIndex("Libroid");

                    b.ToTable("AutoresLibros");
                });

            modelBuilder.Entity("CursoWebApi.Entidades.Comentario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Libroid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Libroid");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("CursoWebApi.Entidades.Libro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("CursoWebApi.Entidades.AutorLibro", b =>
                {
                    b.HasOne("CursoWebApi.Entidades.Autor", "Autor")
                        .WithMany("AutoresLibros")
                        .HasForeignKey("Autorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CursoWebApi.Entidades.Libro", "Libro")
                        .WithMany("AutoresLibros")
                        .HasForeignKey("Libroid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("CursoWebApi.Entidades.Comentario", b =>
                {
                    b.HasOne("CursoWebApi.Entidades.Libro", null)
                        .WithMany("Comentarios")
                        .HasForeignKey("Libroid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CursoWebApi.Entidades.Autor", b =>
                {
                    b.Navigation("AutoresLibros");
                });

            modelBuilder.Entity("CursoWebApi.Entidades.Libro", b =>
                {
                    b.Navigation("AutoresLibros");

                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}

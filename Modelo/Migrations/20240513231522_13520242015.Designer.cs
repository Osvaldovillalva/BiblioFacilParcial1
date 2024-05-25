﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240513231522_13520242015")]
    partial class _13520242015
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.Devolucion", b =>
                {
                    b.Property<int>("DevolucionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevolucionId"));

                    b.Property<DateTime>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrestamoId")
                        .HasColumnType("int");

                    b.HasKey("DevolucionId");

                    b.HasIndex("PrestamoId");

                    b.ToTable("Devoluciones");

                    b.HasData(
                        new
                        {
                            DevolucionId = 1,
                            FechaDevolucion = new DateTime(2024, 5, 10, 20, 15, 22, 602, DateTimeKind.Local).AddTicks(979),
                            PrestamoId = 1
                        },
                        new
                        {
                            DevolucionId = 2,
                            FechaDevolucion = new DateTime(2024, 5, 11, 20, 15, 22, 602, DateTimeKind.Local).AddTicks(984),
                            PrestamoId = 2
                        },
                        new
                        {
                            DevolucionId = 3,
                            FechaDevolucion = new DateTime(2024, 5, 12, 20, 15, 22, 602, DateTimeKind.Local).AddTicks(986),
                            PrestamoId = 3
                        });
                });

            modelBuilder.Entity("Entidades.Libro", b =>
                {
                    b.Property<int>("LibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibroId"));

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponible")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibroId");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            LibroId = 1,
                            Autor = "Gabriel García Márquez",
                            Disponible = true,
                            Titulo = "Cien años de soledad",
                            Ubicacion = "M1"
                        },
                        new
                        {
                            LibroId = 2,
                            Autor = "Miguel de Cervantes",
                            Disponible = true,
                            Titulo = "Don Quijote de la Mancha",
                            Ubicacion = "C1"
                        },
                        new
                        {
                            LibroId = 3,
                            Autor = "Antoine de Saint-Exupéry",
                            Disponible = true,
                            Titulo = "El principito",
                            Ubicacion = "S1"
                        });
                });

            modelBuilder.Entity("Entidades.Prestamo", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrestamoId"));

                    b.Property<bool>("EnPrestamo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaPrestamo")
                        .HasColumnType("datetime2");

                    b.Property<int>("LibroId")
                        .HasColumnType("int");

                    b.Property<int>("SocioId")
                        .HasColumnType("int");

                    b.HasKey("PrestamoId");

                    b.HasIndex("LibroId");

                    b.HasIndex("SocioId");

                    b.ToTable("Prestamos");

                    b.HasData(
                        new
                        {
                            PrestamoId = 1,
                            EnPrestamo = true,
                            FechaPrestamo = new DateTime(2024, 5, 3, 20, 15, 22, 602, DateTimeKind.Local).AddTicks(913),
                            LibroId = 1,
                            SocioId = 1
                        },
                        new
                        {
                            PrestamoId = 2,
                            EnPrestamo = true,
                            FechaPrestamo = new DateTime(2024, 5, 8, 20, 15, 22, 602, DateTimeKind.Local).AddTicks(943),
                            LibroId = 2,
                            SocioId = 2
                        },
                        new
                        {
                            PrestamoId = 3,
                            EnPrestamo = true,
                            FechaPrestamo = new DateTime(2024, 5, 10, 20, 15, 22, 602, DateTimeKind.Local).AddTicks(944),
                            LibroId = 3,
                            SocioId = 3
                        });
                });

            modelBuilder.Entity("Entidades.Socio", b =>
                {
                    b.Property<int>("SocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocioId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocioId");

                    b.ToTable("Socios");

                    b.HasData(
                        new
                        {
                            SocioId = 1,
                            Apellido = "González",
                            Dni = 12345678,
                            Habilitado = true,
                            Nombre = "Ana"
                        },
                        new
                        {
                            SocioId = 2,
                            Apellido = "Martínez",
                            Dni = 87654321,
                            Habilitado = true,
                            Nombre = "Juan"
                        },
                        new
                        {
                            SocioId = 3,
                            Apellido = "López",
                            Dni = 98765432,
                            Habilitado = true,
                            Nombre = "María"
                        });
                });

            modelBuilder.Entity("Entidades.Devolucion", b =>
                {
                    b.HasOne("Entidades.Prestamo", "Prestamo")
                        .WithMany()
                        .HasForeignKey("PrestamoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prestamo");
                });

            modelBuilder.Entity("Entidades.Prestamo", b =>
                {
                    b.HasOne("Entidades.Libro", "Libro")
                        .WithMany()
                        .HasForeignKey("LibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Socio", "Socio")
                        .WithMany()
                        .HasForeignKey("SocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libro");

                    b.Navigation("Socio");
                });
#pragma warning restore 612, 618
        }
    }
}

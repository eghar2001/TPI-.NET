﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Datos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231104192556_maximoDescripcion")]
    partial class maximoDescripcion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entidades.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("UltimoPrecio")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("Entidades.Horario", b =>
                {
                    b.Property<int>("TurnoId")
                        .HasColumnType("int");

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<string>("HoraFin")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("HoraInicio")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("TurnoId", "DiaSemana");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Entidades.InscripcionTurno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaHoraBaja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHoraInscripcion")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurnoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TurnoId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("FechaHoraInscripcion", "UsuarioId")
                        .IsUnique();

                    b.ToTable("InscripcionesTurno");
                });

            modelBuilder.Entity("Entidades.Instalacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cupo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("UltimoPrecio")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Instalaciones");
                });

            modelBuilder.Entity("Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Entidades.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("Entidades.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantidadAsitentes")
                        .HasColumnType("int");

                    b.Property<int>("DuracionEnHoras")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHoraReserva")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHoraUso")
                        .HasColumnType("datetime2");

                    b.Property<int>("InstalacionId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("InstalacionId", "FechaHoraReserva")
                        .IsUnique();

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Entidades.TipoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Descripcion")
                        .IsUnique();

                    b.ToTable("TiposUsuario");
                });

            modelBuilder.Entity("Entidades.Turno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("InstalacionId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId");

                    b.HasIndex("InstalacionId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("TipoUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Dni")
                        .IsUnique();

                    b.HasIndex("NombreUsuario")
                        .IsUnique();

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Entidades.ValorActividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActividadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDesde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("ActividadId", "FechaDesde")
                        .IsUnique();

                    b.ToTable("ValoresActividad");
                });

            modelBuilder.Entity("Entidades.ValorProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaDesde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId", "FechaDesde")
                        .IsUnique();

                    b.ToTable("ValoresProducto");
                });

            modelBuilder.Entity("Entidades.ValorReserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaDesde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("InstalacionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("InstalacionId", "FechaDesde")
                        .IsUnique();

                    b.ToTable("ValoresReserva");
                });

            modelBuilder.Entity("Entidades.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("ProductoId", "UsuarioId", "FechaVenta")
                        .IsUnique();

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Entidades.Horario", b =>
                {
                    b.HasOne("Entidades.Turno", "Turno")
                        .WithMany("Horarios")
                        .HasForeignKey("TurnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turno");
                });

            modelBuilder.Entity("Entidades.InscripcionTurno", b =>
                {
                    b.HasOne("Entidades.Turno", "Turno")
                        .WithMany()
                        .HasForeignKey("TurnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turno");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.Reserva", b =>
                {
                    b.HasOne("Entidades.Instalacion", "Instalacion")
                        .WithMany()
                        .HasForeignKey("InstalacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instalacion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.Turno", b =>
                {
                    b.HasOne("Entidades.Actividad", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Instalacion", "Instalacion")
                        .WithMany()
                        .HasForeignKey("InstalacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");

                    b.Navigation("Instalacion");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Entidades.Usuario", b =>
                {
                    b.HasOne("Entidades.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("Entidades.ValorActividad", b =>
                {
                    b.HasOne("Entidades.Actividad", "Actividad")
                        .WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actividad");
                });

            modelBuilder.Entity("Entidades.ValorProducto", b =>
                {
                    b.HasOne("Entidades.Producto", null)
                        .WithMany("Valores")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entidades.ValorReserva", b =>
                {
                    b.HasOne("Entidades.Instalacion", "Instalacion")
                        .WithMany()
                        .HasForeignKey("InstalacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instalacion");
                });

            modelBuilder.Entity("Entidades.Venta", b =>
                {
                    b.HasOne("Entidades.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entidades.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Entidades.Producto", b =>
                {
                    b.Navigation("Valores");
                });

            modelBuilder.Entity("Entidades.Turno", b =>
                {
                    b.Navigation("Horarios");
                });
#pragma warning restore 612, 618
        }
    }
}

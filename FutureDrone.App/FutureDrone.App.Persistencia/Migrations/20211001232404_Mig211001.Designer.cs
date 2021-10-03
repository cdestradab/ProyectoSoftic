﻿// <auto-generated />
using FutureDrone.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FutureDrone.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211001232404_Mig211001")]
    partial class Mig211001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FutureDrone.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("FutureDrone.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Ciudad")
                        .HasColumnType("int");

                    b.Property<int>("id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("FutureDrone.App.Dominio.Drone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("modelo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Drone");
                });

            modelBuilder.Entity("FutureDrone.App.Dominio.Empleado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("FutureDrone.App.Dominio.Encuesta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Envio")
                        .HasColumnType("int");

                    b.Property<string>("pregunta1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pregunta2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pregunta3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pregunta4")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Encuesta");
                });

            modelBuilder.Entity("FutureDrone.App.Dominio.Envio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("direccion_destinatario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento_destinatario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento_empleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("fecha_entrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Ciudad")
                        .HasColumnType("int");

                    b.Property<int>("id_Drone")
                        .HasColumnType("int");

                    b.Property<int>("id_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("nombre_destinatario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("producto_envio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("valor")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Envio");
                });

            modelBuilder.Entity("FutureDrone.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rol")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}

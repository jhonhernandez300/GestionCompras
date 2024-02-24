﻿// <auto-generated />
using System;
using LionDev;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LionDev.Models.Comprador", b =>
                {
                    b.Property<Guid>("IdComprador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("NumeroDeDocumento")
                        .HasMaxLength(16)
                        .IsUnicode(true)
                        .HasColumnType("int");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("TipoDeDocumento")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdComprador");

                    b.ToTable("Compradores");

                    b.HasData(
                        new
                        {
                            IdComprador = new Guid("56665716-5d79-4550-a3dd-8b0c1901124d"),
                            Apellidos = "Falcao",
                            Contrasena = "Rada1",
                            CorreoElectronico = "rada@gmail.com",
                            Direccion = "Calle 1",
                            Genero = "Masculino",
                            Nombres = "Radamel",
                            NumeroDeDocumento = 12345,
                            Rol = "Administrador",
                            TipoDeDocumento = "Cedula"
                        },
                        new
                        {
                            IdComprador = new Guid("3156310b-7290-482a-8fb2-8ae37d6b09fd"),
                            Apellidos = "Rodriguez",
                            Contrasena = "James1",
                            CorreoElectronico = "james@gmail.com",
                            Direccion = "Calle 2",
                            Genero = "Masculino",
                            Nombres = "James",
                            NumeroDeDocumento = 12346,
                            Rol = "Empleado",
                            TipoDeDocumento = "Cedula"
                        });
                });

            modelBuilder.Entity("LionDev.Models.Producto", b =>
                {
                    b.Property<Guid>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsDeLosMasBuscados")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParaSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Talla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            IdProducto = new Guid("8a3ddd4f-fffc-44e7-8666-1eb7b6638071"),
                            Cantidad = 15,
                            Color = "Negro",
                            Descripcion = "Chaqueta",
                            EsDeLosMasBuscados = true,
                            Nombre = "Chaqueta",
                            ParaSexo = "Masculino",
                            Referencia = "C3",
                            Talla = "14",
                            UrlImagen = "ProductosImagenes/C3.png",
                            Valor = 140000
                        },
                        new
                        {
                            IdProducto = new Guid("941b956e-3ac5-4d51-8a66-2601e21c9334"),
                            Cantidad = 15,
                            Color = "Blanco y rojo",
                            Descripcion = "Falda larga",
                            EsDeLosMasBuscados = true,
                            Nombre = "Falda larga",
                            ParaSexo = "Femenino",
                            Referencia = "FL3",
                            Talla = "14",
                            UrlImagen = "ProductosImagenes/FL3.png",
                            Valor = 35000
                        },
                        new
                        {
                            IdProducto = new Guid("f5cda447-6599-4dfc-af94-c674539edc03"),
                            Cantidad = 25,
                            Color = "Blanco",
                            Descripcion = "Camiseta corta",
                            EsDeLosMasBuscados = true,
                            Nombre = "Camiseta",
                            ParaSexo = "Femenino",
                            Referencia = "CA5",
                            Talla = "16",
                            UrlImagen = "ProductosImagenes/CA5.png",
                            Valor = 45000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

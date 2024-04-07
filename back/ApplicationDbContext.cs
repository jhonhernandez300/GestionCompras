using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LionDev.Models;

namespace LionDev
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                   : base(options)
        { }

        //public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        //public DbSet<Factura> Facturas { get; set; }
        //public DbSet<Marca> Marcas { get; set; }        
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relaciones y configuraciones de modelos aquí usando Fluent API

            //Las PKs
            //modelBuilder.Entity<DetalleFactura>()
            //    .HasKey(df => df.IdDetalleFactura);

            modelBuilder.Entity<Producto>()
                .HasKey(df => df.IdProducto);

            modelBuilder.Entity<Usuario>()
               .HasKey(df => df.IdUsuario);

            //modelBuilder.Entity<Factura>()
            //    .HasKey(df => df.IdFactura);

            //modelBuilder.Entity<Marca>()
            //    .HasKey(df => df.IdMarca);         

            //modelBuilder.Entity<DetalleFactura>()
            //    .Property(df => df.Cantidad)
            //    .IsRequired();

            //Las relaciones
            //modelBuilder.Entity<DetalleFactura>()
            //    .HasOne(df => df.Factura)
            //    .WithMany(f => f.DetalleFactura)
            //    .HasForeignKey(df => df.IdFactura);

            //modelBuilder.Entity<Factura>()
            //    .HasOne(df => df.Comprador)
            //    .WithMany(f => f.Factura)
            //    .HasForeignKey(df => df.IdComprador);

            //modelBuilder.Entity<DetalleFactura>()
            //    .HasOne(df => df.Producto)
            //    .WithMany(f => f.DetalleFactura)
            //    .HasForeignKey(df => df.IdProducto);

            //modelBuilder.Entity<Producto>()
            //    .HasOne(df => df.Marca)
            //    .WithMany(f => f.Producto)
            //    .HasForeignKey(df => df.IdMarca);            

            // Seeds
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { 
                    IdUsuario = Guid.NewGuid(), 
                    Nombres = "Radamel",
                    Apellidos = "Falcao",
                    CorreoElectronico = "rada@gmail.com",
                    TipoDeDocumento = "Cedula",
                    NumeroDeDocumento = "12345",
                    Contrasena = "Rada1",
                    Genero = "Masculino",
                    Direccion = "Calle 1",
                    Rol = "Comprador"
                },
                new Usuario
                {
                    IdUsuario = Guid.NewGuid(),
                    Nombres = "James",
                    Apellidos = "Rodriguez",
                    CorreoElectronico = "james@gmail.com",
                    TipoDeDocumento = "Cedula",
                    NumeroDeDocumento = "12346",
                    Contrasena = "James1",
                    Genero = "Masculino",
                    Direccion = "Calle 2",
                    Rol = "Administrador"
                }
            );

            modelBuilder.Entity<Producto>().HasData(              
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Buso saco rick and morty fuck",
                    Referencia = "BSRAMF",
                    UrlImagen = "ProductosImagenes/buso-saco-rick-and-morty-fuck.png",
                    Descripcion = "Buso saco rick and morty fuck",
                    Color = "Negro",
                    Cantidad = 15,
                    Talla = "14",
                    Valor = 140000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Masculino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Sudadera clásica nautica",
                    Referencia = "SC",
                    UrlImagen = "ProductosImagenes/sudadera-clasica-nautica.png",
                    Descripcion = "Sudadera clásica nautica",
                    Color = "Negro",
                    Cantidad = 25,
                    Talla = "15",
                    Valor = 145000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Masculino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Buzo compresión licra",
                    Referencia = "BCL",
                    UrlImagen = "ProductosImagenes/buzo-compresio-licra.png",
                    Descripcion = "Buzo de compresión en licra protección UV",
                    Color = "Negro",
                    Cantidad = 35,
                    Talla = "5",
                    Valor = 3000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Masculino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Buzo saco anime",
                    Referencia = "BSA",
                    UrlImagen = "ProductosImagenes/buzo-saco-anime.png",
                    Descripcion = "Buzo saco anime one piece",
                    Color = "negro y colores en el centro",
                    Cantidad = 19,
                    Talla = "14",
                    Valor = 35000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "masculino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Camiseta compresión licra",
                    Referencia = "CCL",
                    UrlImagen = "ProductosImagenes/buzo-saco-anime.png",
                    Descripcion = "Camiseta corta",
                    Color = "Blanco",
                    Cantidad = 25,
                    Talla = "16",
                    Valor = 45000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Femenino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Camiseta compresión licra",
                    Referencia = "CCL",
                    UrlImagen = "ProductosImagenes/buzo-saco-anime.png",
                    Descripcion = "Camiseta compresión licra UV slim",
                    Color = "Blanco",
                    Cantidad = 85,
                    Talla = "16",
                    Valor = 45000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Masculino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Pantalon compresión licra",
                    Referencia = "PCL",
                    UrlImagen = "ProductosImagenes/pantalon-compresion-licra.png",
                    Descripcion = "Pantalon compresión licra",
                    Color = "Blanco",
                    Cantidad = 87,
                    Talla = "16",
                    Valor = 48000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Masculino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Medias veladas térmicas",
                    Referencia = "MVT",
                    UrlImagen = "ProductosImagenes/medias-veladas-termicas.png",
                    Descripcion = "Medias veladas termicas mujer efecto piel",
                    Color = "Varios colores",
                    Cantidad = 87,
                    Talla = "17",
                    Valor = 48000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Femenino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Medias antideslizantes",
                    Referencia = "MA",
                    UrlImagen = "ProductosImagenes/medias-antideslizantes-yoga-pilates.png",
                    Descripcion = "Medias antideslizantes yoga pilates fitnics",
                    Color = "Varios colores",
                    Cantidad = 65,
                    Talla = "15",
                    Valor = 145000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Femenino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Uniforme mujer antifluido",
                    Referencia = "UMA",
                    UrlImagen = "ProductosImagenes/uniforme-mujer-antifluido.png",
                    Descripcion = "Uniforme mujer antifluido scrub",
                    Color = "Rojo",
                    Cantidad = 28,
                    Talla = "95",
                    Valor = 145000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Femenino"
                },
                new Producto
                {
                    IdProducto = Guid.NewGuid(),
                    Nombre = "Vestido corto juvenil",
                    Referencia = "SCR",
                    UrlImagen = "ProductosImagenes/vestido-corto-juvenil.png",
                    Descripcion = "Sudadera camuflada reforzada en tela náutica",
                    Color = "Blanco y negro",
                    Cantidad = 25,
                    Talla = "95",
                    Valor = 85000,
                    EsDeLosMasBuscados = true,
                    ParaSexo = "Femenino"
                }
            );


            base.OnModelCreating(modelBuilder);
    }
}
}

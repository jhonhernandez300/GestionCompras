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

        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Comprador> Compradores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relaciones y configuraciones de modelos aquí usando Fluent API

            //Las PKs
            modelBuilder.Entity<DetalleFactura>()
                .HasKey(df => df.IdDetalleFactura);

            modelBuilder.Entity<Producto>()
                .HasKey(df => df.IdProducto);

            modelBuilder.Entity<Factura>()
                .HasKey(df => df.IdFactura);

            modelBuilder.Entity<Marca>()
                .HasKey(df => df.IdMarca);

            modelBuilder.Entity<Comprador>()
                .HasKey(df => df.IdComprador);

            modelBuilder.Entity<DetalleFactura>()
                .Property(df => df.Cantidad)
                .IsRequired();

            //Las relaciones
            modelBuilder.Entity<DetalleFactura>()
                .HasOne(df => df.Factura)
                .WithMany(f => f.DetalleFactura)
                .HasForeignKey(df => df.IdFactura);

            modelBuilder.Entity<Factura>()
                .HasOne(df => df.Comprador)
                .WithMany(f => f.Factura)
                .HasForeignKey(df => df.IdComprador);

            modelBuilder.Entity<DetalleFactura>()
                .HasOne(df => df.Producto)
                .WithMany(f => f.DetalleFactura)
                .HasForeignKey(df => df.IdProducto);

            modelBuilder.Entity<Producto>()
                .HasOne(df => df.Marca)
                .WithMany(f => f.Producto)
                .HasForeignKey(df => df.IdMarca);

            //Reglas de los campos
            modelBuilder.Entity<Comprador>(entity =>
            {
                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode()
                    .HasColumnType("nvarchar(30)"); // Tipo de columna y longitud en la base de datos

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode()
                    .HasColumnType("nvarchar(30)");

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode()
                    .HasColumnType("nvarchar(30)");

                entity.Property(e => e.TipoDeDocumento)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode()
                    .HasColumnType("nvarchar(30)");

                entity.Property(e => e.NumeroDeDocumento)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode();                    

            });


            // Seeds
            //modelBuilder.Entity<Marca>().HasData(
            //    new Marca { IdMarca = Guid.NewGuid(), Nombre = "Marca1" },
            //    new Marca { IdMarca = Guid.NewGuid(), Nombre = "Marca2" },
            //    new Marca { IdMarca = Guid.NewGuid(), Nombre = "Marca3" }
            //);

            //modelBuilder.Entity<Producto>().HasData(
            //    new Producto { IdProducto = Guid.NewGuid(), Nombre = "Producto1", Referencia = "Ref1", Imagen = "Imagen1", Descripcion = "Desc1", Color = "Color1", Cantidad = 10, Talla = "Talla1", Valor = 100.50m, IdMarca = Guid.NewGuid() },
            //    new Producto { IdProducto = Guid.NewGuid(), Nombre = "Producto2", Referencia = "Ref2", Imagen = "Imagen2", Descripcion = "Desc2", Color = "Color2", Cantidad = 20, Talla = "Talla2", Valor = 200.75m, IdMarca = Guid.NewGuid() },
            //    new Producto { IdProducto = Guid.NewGuid(), Nombre = "Producto3", Referencia = "Ref3", Imagen = "Imagen3", Descripcion = "Desc3", Color = "Color3", Cantidad = 30, Talla = "Talla3", Valor = 300.99m, IdMarca = Guid.NewGuid() }
            //);

            // Seeds para otros modelos...

            base.OnModelCreating(modelBuilder);
    }
}
}

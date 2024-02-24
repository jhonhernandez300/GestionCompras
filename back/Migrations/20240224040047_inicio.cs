using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compradores",
                columns: table => new
                {
                    IdComprador = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TipoDeDocumento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NumeroDeDocumento = table.Column<int>(type: "int", maxLength: 16, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compradores", x => x.IdComprador);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlImagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Talla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    EsDeLosMasBuscados = table.Column<bool>(type: "bit", nullable: false),
                    ParaSexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });

            migrationBuilder.InsertData(
                table: "Compradores",
                columns: new[] { "IdComprador", "Apellidos", "Contrasena", "CorreoElectronico", "Direccion", "Genero", "Nombres", "NumeroDeDocumento", "Rol", "TipoDeDocumento" },
                values: new object[,]
                {
                    { new Guid("3156310b-7290-482a-8fb2-8ae37d6b09fd"), "Rodriguez", "James1", "james@gmail.com", "Calle 2", "Masculino", "James", 12346, "Empleado", "Cedula" },
                    { new Guid("56665716-5d79-4550-a3dd-8b0c1901124d"), "Falcao", "Rada1", "rada@gmail.com", "Calle 1", "Masculino", "Radamel", 12345, "Administrador", "Cedula" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Color", "Descripcion", "EsDeLosMasBuscados", "Nombre", "ParaSexo", "Referencia", "Talla", "UrlImagen", "Valor" },
                values: new object[,]
                {
                    { new Guid("8a3ddd4f-fffc-44e7-8666-1eb7b6638071"), 15, "Negro", "Chaqueta", true, "Chaqueta", "Masculino", "C3", "14", "ProductosImagenes/C3.png", 140000 },
                    { new Guid("941b956e-3ac5-4d51-8a66-2601e21c9334"), 15, "Blanco y rojo", "Falda larga", true, "Falda larga", "Femenino", "FL3", "14", "ProductosImagenes/FL3.png", 35000 },
                    { new Guid("f5cda447-6599-4dfc-af94-c674539edc03"), 25, "Blanco", "Camiseta corta", true, "Camiseta", "Femenino", "CA5", "16", "ProductosImagenes/CA5.png", 45000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compradores");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}

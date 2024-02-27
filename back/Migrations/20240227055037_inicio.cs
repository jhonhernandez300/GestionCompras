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

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "Compradores",
                columns: new[] { "IdComprador", "Apellidos", "Contrasena", "CorreoElectronico", "Direccion", "Genero", "Nombres", "NumeroDeDocumento", "Rol", "TipoDeDocumento" },
                values: new object[,]
                {
                    { new Guid("aac00985-af38-4636-9fa9-241ffdead3e2"), "Rodriguez", "James1", "james@gmail.com", "Calle 2", "Masculino", "James", 12346, "Empleado", "Cedula" },
                    { new Guid("be2302f6-c140-47f7-8433-a22fd4e29d90"), "Falcao", "Rada1", "rada@gmail.com", "Calle 1", "Masculino", "Radamel", 12345, "Administrador", "Cedula" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Color", "Descripcion", "EsDeLosMasBuscados", "Nombre", "ParaSexo", "Referencia", "Talla", "UrlImagen", "Valor" },
                values: new object[,]
                {
                    { new Guid("e4daf067-6a3a-42ec-a787-242cd3826506"), 15, "Blanco y rojo", "Falda larga", true, "Falda larga", "Femenino", "FL3", "14", "ProductosImagenes/FL3.png", 35000 },
                    { new Guid("eec034eb-eec3-4fb0-9b4d-5466ac7679c0"), 15, "Negro", "Chaqueta", true, "Chaqueta", "Masculino", "C3", "14", "ProductosImagenes/C3.png", 140000 },
                    { new Guid("f919dd8d-63d8-4ab6-a4a8-094444569fc9"), 25, "Blanco", "Camiseta corta", true, "Camiseta", "Femenino", "CA5", "16", "ProductosImagenes/CA5.png", 45000 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Apellidos", "CorreoElectronico", "Nombres", "Password", "Rol" },
                values: new object[,]
                {
                    { new Guid("b53bc02a-199f-49bd-a2b5-add5a4401977"), "Hernandez", "jhon@gmail.com", "Jhon", "Jhon1", "Administrador" },
                    { new Guid("c7296d74-1865-4d62-aa8e-2f6eb2f77e21"), "Perez", "pedro@gmail.com", "Pedro", "Pedro1", "Empleado" },
                    { new Guid("fc61491e-752f-4f7c-a8c9-d3d1626d30d5"), "Muñoz", "yurani@gmail.com", "Yurani", "Yurani1", "Comprador" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compradores");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

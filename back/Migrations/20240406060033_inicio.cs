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
                    TipoDeDocumento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NumeroDeDocumento = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Color", "Descripcion", "EsDeLosMasBuscados", "Nombre", "ParaSexo", "Referencia", "Talla", "UrlImagen", "Valor" },
                values: new object[,]
                {
                    { new Guid("1140eff8-c3e3-4930-b4d5-4744eea5fb55"), 35, "Negro", "Buzo de compresión en licra protección UV", true, "Buzo compresión licra", "Masculino", "BCL", "5", "ProductosImagenes/buzo-compresio-licra.png", 3000 },
                    { new Guid("2a0f3195-98ad-4d1a-9a1c-5ee4c193d16f"), 25, "Negro", "Sudadera clásica nautica", true, "Sudadera clásica nautica", "Masculino", "SC", "15", "ProductosImagenes/sudadera-clasica-nautica.png", 145000 },
                    { new Guid("3272e317-937b-4342-93b1-83a55c5cadf4"), 85, "Blanco", "Camiseta compresión licra UV slim", true, "Camiseta compresión licra", "Masculino", "CCL", "16", "ProductosImagenes/buzo-saco-anime.png", 45000 },
                    { new Guid("4aac29d6-f416-4dc9-9ffe-06c7ce541489"), 15, "Negro", "Buso saco rick and morty fuck", true, "Buso saco rick and morty fuck", "Masculino", "BSRAMF", "14", "ProductosImagenes/buso-saco-rick-and-morty-fuck.png", 140000 },
                    { new Guid("5f504e99-69a2-499b-a928-3383c831c1bc"), 28, "Rojo", "Uniforme mujer antifluido scrub", true, "Uniforme mujer antifluido", "Femenino", "UMA", "95", "ProductosImagenes/uniforme-mujer-antifluido.png", 145000 },
                    { new Guid("c42f56c8-9791-4e75-be39-0f5c23a04a57"), 65, "Varios colores", "Medias antideslizantes yoga pilates fitnics", true, "Medias antideslizantes", "Femenino", "MA", "15", "ProductosImagenes/medias-antideslizantes-yoga-pilates.png", 145000 },
                    { new Guid("ca024ed8-c0fa-4c25-8f7a-ced88b56fd07"), 25, "Blanco y negro", "Sudadera camuflada reforzada en tela náutica", true, "Vestido corto juvenil", "Femenino", "SCR", "95", "ProductosImagenes/vestido-corto-juvenil.png", 85000 },
                    { new Guid("cd08f9e5-479b-49be-b261-c5cb2f657cf4"), 87, "Varios colores", "Medias veladas termicas mujer efecto piel", true, "Medias veladas térmicas", "Femenino", "MVT", "17", "ProductosImagenes/medias-veladas-termicas.png", 48000 },
                    { new Guid("e1c7c2e6-b56d-46e0-afa0-5b7712ccd344"), 19, "negro y colores en el centro", "Buzo saco anime one piece", true, "Buzo saco anime", "masculino", "BSA", "14", "ProductosImagenes/buzo-saco-anime.png", 35000 },
                    { new Guid("e81551ad-c657-4a4e-b6ff-1d143508990f"), 87, "Blanco", "Pantalon compresión licra", true, "Pantalon compresión licra", "Masculino", "PCL", "16", "ProductosImagenes/pantalon-compresion-licra.png", 48000 },
                    { new Guid("f7db1a26-b48c-4a13-b823-99ebfbc12af4"), 25, "Blanco", "Camiseta corta", true, "Camiseta compresión licra", "Femenino", "CCL", "16", "ProductosImagenes/buzo-saco-anime.png", 45000 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Apellidos", "Contrasena", "CorreoElectronico", "Direccion", "Genero", "Nombres", "NumeroDeDocumento", "Rol", "TipoDeDocumento" },
                values: new object[,]
                {
                    { new Guid("2a9087f2-d12d-475c-ad5a-468809b02a37"), "Falcao", "Rada1", "rada@gmail.com", "Calle 1", "Masculino", "Radamel", "12345", "Comprador", "Cedula" },
                    { new Guid("4a8275e6-fba8-4176-9e59-507a49374cae"), "Rodriguez", "James1", "james@gmail.com", "Calle 2", "Masculino", "James", "12346", "Administrador", "Cedula" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

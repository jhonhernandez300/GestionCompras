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
                    { new Guid("1340af74-4422-4068-930e-a013c205c5f2"), 87, "Varios colores", "Medias veladas termicas mujer efecto piel", true, "Medias veladas térmicas", "Femenino", "MVT", "17", "../../../../assets/ProductosImagenes/medias-veladas-termicas.png", 48000 },
                    { new Guid("26ea0ca2-e2e1-400f-94cb-7c8e444b2f82"), 65, "Varios colores", "Medias antideslizantes yoga pilates fitnics", true, "Medias antideslizantes", "Femenino", "MA", "15", "../../../../assets/ProductosImagenes/medias-antideslizantes-yoga-pilates.png", 145000 },
                    { new Guid("5cff3790-34eb-4039-bac1-9002691622df"), 25, "Blanco y negro", "Sudadera camuflada reforzada en tela náutica", true, "Vestido corto juvenil", "Femenino", "SCR", "95", "../../../../assets/ProductosImagenes/vestido-corto-juvenil.png", 85000 },
                    { new Guid("708e9934-c409-406f-9372-d990e36c6e16"), 15, "Negro", "Buso saco rick and morty fuck", true, "Buso saco rick and morty fuck", "Masculino", "BSRAMF", "14", "../../../../assets/ProductosImagenes/buso-saco-rick-and-morty-fuck.png", 140000 },
                    { new Guid("7eee4293-49b3-492b-9897-59b7b83abc50"), 87, "Blanco", "Pantalon compresión licra", true, "Pantalon compresión licra", "Masculino", "PCL", "16", "../../../../assets/ProductosImagenes/pantalon-compresion-licra.png", 48000 },
                    { new Guid("a7fc3a86-a6ec-4792-adea-ce3b423a33fe"), 35, "Negro", "Buzo de compresión en licra protección UV", true, "Buzo compresión licra", "Masculino", "BCL", "5", "../../../../assets/ProductosImagenes/buzo-compresio-licra.png", 3000 },
                    { new Guid("b3bf81b2-dd8d-47c1-8032-262dd1f6c351"), 19, "negro y colores en el centro", "Buzo saco anime one piece", true, "Buzo saco anime", "masculino", "BSA", "14", "../../../../assets/ProductosImagenes/buzo-saco-anime.png", 35000 },
                    { new Guid("bafcb817-ae03-4c3c-9119-b8b98027177b"), 28, "Rojo", "Uniforme mujer antifluido scrub", true, "Uniforme mujer antifluido", "Femenino", "UMA", "95", "../../../../assets/ProductosImagenes/uniforme-mujer-antifluido.png", 145000 },
                    { new Guid("d72fb25b-fa90-4e13-80bf-fa0a6ae0afc2"), 85, "Blanco", "Camiseta compresión licra UV slim", true, "Camiseta compresión licra", "Masculino", "CCL", "16", "../../../../assets/ProductosImagenes/buzo-saco-anime.png", 45000 },
                    { new Guid("f1bb9445-1d57-43e0-81e3-3e6d153d717f"), 25, "Negro", "Sudadera clásica nautica", true, "Sudadera clásica nautica", "Masculino", "SC", "15", "../../../../assets/ProductosImagenes/sudadera-clasica-nautica.png", 145000 },
                    { new Guid("f986b47b-89b5-417f-95dc-d78769570ca1"), 25, "Blanco", "Camiseta corta", true, "Camiseta compresión licra", "Femenino", "CCL", "16", "../../../../assets/ProductosImagenes/buzo-saco-anime.png", 45000 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Apellidos", "Contrasena", "CorreoElectronico", "Direccion", "Genero", "Nombres", "NumeroDeDocumento", "Rol", "TipoDeDocumento" },
                values: new object[,]
                {
                    { new Guid("16430be5-b976-4403-be9c-0fd9e6f81bc2"), "Falcao", "Rada1", "rada@gmail.com", "Calle 1", "Masculino", "Radamel", "12345", "Comprador", "Cedula" },
                    { new Guid("8ea02594-77a1-481f-a565-1d6ead77bc1d"), "Rodriguez", "James1", "james@gmail.com", "Calle 2", "Masculino", "James", "12346", "Administrador", "Cedula" }
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

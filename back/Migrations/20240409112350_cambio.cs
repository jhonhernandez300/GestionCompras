using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class cambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("1340af74-4422-4068-930e-a013c205c5f2"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("26ea0ca2-e2e1-400f-94cb-7c8e444b2f82"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("5cff3790-34eb-4039-bac1-9002691622df"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("708e9934-c409-406f-9372-d990e36c6e16"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("7eee4293-49b3-492b-9897-59b7b83abc50"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("a7fc3a86-a6ec-4792-adea-ce3b423a33fe"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("b3bf81b2-dd8d-47c1-8032-262dd1f6c351"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("bafcb817-ae03-4c3c-9119-b8b98027177b"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("d72fb25b-fa90-4e13-80bf-fa0a6ae0afc2"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("f1bb9445-1d57-43e0-81e3-3e6d153d717f"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("f986b47b-89b5-417f-95dc-d78769570ca1"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("16430be5-b976-4403-be9c-0fd9e6f81bc2"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("8ea02594-77a1-481f-a565-1d6ead77bc1d"));

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Color", "Descripcion", "EsDeLosMasBuscados", "Nombre", "ParaSexo", "Referencia", "Talla", "UrlImagen", "Valor" },
                values: new object[,]
                {
                    { new Guid("14792c94-c0d0-4f8e-b18d-60364cc9655e"), 65, "Varios colores", "Medias antideslizantes yoga pilates fitnics", true, "Medias antideslizantes", "Femenino", "MA", "15", "../../../../assets/medias-antideslizantes-yoga-pilates.png", 145000 },
                    { new Guid("4285a1a3-be4b-47cb-ab4b-ad3049cea3e7"), 25, "Blanco", "Camiseta corta", true, "Camiseta compresión licra", "Femenino", "CCL", "16", "../../../../assets/buzo-saco-anime.png", 45000 },
                    { new Guid("6daa735b-a825-4049-bc3f-076692e57660"), 25, "Blanco y negro", "Sudadera camuflada reforzada en tela náutica", true, "Vestido corto juvenil", "Femenino", "SCR", "95", "../../../../assets/vestido-corto-juvenil.png", 85000 },
                    { new Guid("787c05f4-48b2-43d6-a88c-25c20c0a60d4"), 15, "Negro", "Buso saco rick and morty fuck", true, "Buso saco rick and morty fuck", "Masculino", "BSRAMF", "14", "../../../../assets/buso-saco-rick-and-morty-fuck.png", 140000 },
                    { new Guid("84d2d2cd-1623-433d-9b04-b3a0f6a241fd"), 35, "Negro", "Buzo de compresión en licra protección UV", true, "Buzo compresión licra", "Masculino", "BCL", "5", "../../../../assets/buzo-compresio-licra.png", 3000 },
                    { new Guid("85b0f514-ec57-4494-8a0d-2a90ef685f2f"), 19, "negro y colores en el centro", "Buzo saco anime one piece", true, "Buzo saco anime", "masculino", "BSA", "14", "../../../../assets/buzo-saco-anime.png", 35000 },
                    { new Guid("8ed07524-6dc2-49df-b5a5-aba35a67e19e"), 87, "Varios colores", "Medias veladas termicas mujer efecto piel", true, "Medias veladas térmicas", "Femenino", "MVT", "17", "../../../../assets/medias-veladas-termicas.png", 48000 },
                    { new Guid("a252b2d7-52cf-46bf-b813-17545ff78de5"), 87, "Blanco", "Pantalon compresión licra", true, "Pantalon compresión licra", "Masculino", "PCL", "16", "../../../../assets/pantalon-compresion-licra.png", 48000 },
                    { new Guid("da28b8eb-b853-4bd9-90cf-c855b2eda97d"), 85, "Blanco", "Camiseta compresión licra UV slim", true, "Camiseta compresión licra", "Masculino", "CCL", "16", "../../../../assets/buzo-saco-anime.png", 45000 },
                    { new Guid("dfd7e68b-3734-4b18-9559-c757092706ac"), 25, "Negro", "Sudadera clásica nautica", true, "Sudadera clásica nautica", "Masculino", "SC", "15", "../../../../assets/sudadera-clasica-nautica.png", 145000 },
                    { new Guid("fc72f1e5-9d9c-4fac-b0b8-efc6fabacd32"), 28, "Rojo", "Uniforme mujer antifluido scrub", true, "Uniforme mujer antifluido", "Femenino", "UMA", "95", "../../../../assets/uniforme-mujer-antifluido.png", 145000 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Apellidos", "Contrasena", "CorreoElectronico", "Direccion", "Genero", "Nombres", "NumeroDeDocumento", "Rol", "TipoDeDocumento" },
                values: new object[,]
                {
                    { new Guid("b56cd5a2-6ded-4284-818a-2b5a1952667e"), "Falcao", "Rada1", "rada@gmail.com", "Calle 1", "Masculino", "Radamel", "12345", "Comprador", "Cedula" },
                    { new Guid("d2f46a3e-7783-4590-8564-8979f0bba1d3"), "Rodriguez", "James1", "james@gmail.com", "Calle 2", "Masculino", "James", "12346", "Administrador", "Cedula" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("14792c94-c0d0-4f8e-b18d-60364cc9655e"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("4285a1a3-be4b-47cb-ab4b-ad3049cea3e7"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("6daa735b-a825-4049-bc3f-076692e57660"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("787c05f4-48b2-43d6-a88c-25c20c0a60d4"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("84d2d2cd-1623-433d-9b04-b3a0f6a241fd"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("85b0f514-ec57-4494-8a0d-2a90ef685f2f"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("8ed07524-6dc2-49df-b5a5-aba35a67e19e"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("a252b2d7-52cf-46bf-b813-17545ff78de5"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("da28b8eb-b853-4bd9-90cf-c855b2eda97d"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("dfd7e68b-3734-4b18-9559-c757092706ac"));

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: new Guid("fc72f1e5-9d9c-4fac-b0b8-efc6fabacd32"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("b56cd5a2-6ded-4284-818a-2b5a1952667e"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: new Guid("d2f46a3e-7783-4590-8564-8979f0bba1d3"));

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
    }
}

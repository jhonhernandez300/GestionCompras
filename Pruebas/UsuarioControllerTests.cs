using Backend.Controllers;
using LionDev;
using LionDev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Pruebas
{
    public class UsuarioControllerTests : BasePruebas
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public UsuarioControllerTests()
        {
            var nombreBD = Guid.NewGuid().ToString();
            _context = ConstruirContext(nombreBD);
            _configuration = ConstruirConfiguration();
        }

        [Fact]
        public async Task ObtenerLosUsuarios()
        {
            //Preparación
            _context.Usuarios.Add(new Usuario
            {
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
            });
            await _context.SaveChangesAsync();

            //Prueba            
            var controller = ConstruirUsuarioController();
            var respuesta = await controller.Obtener();

            //Verificación
            Assert.NotNull(respuesta);
        }

        [Fact]
        public async Task ObtenerUsuarioExistente()
        {
            // Preparación
            var idUsuario = Guid.NewGuid();
            var usuario = new Usuario
            {
                IdUsuario = idUsuario,
                Nombres = "Radamel",
                Apellidos = "Falcao",
                CorreoElectronico = "rada@gmail.com",
                TipoDeDocumento = "Cedula",
                NumeroDeDocumento = "12345",
                Contrasena = "Rada1",
                Genero = "Masculino",
                Direccion = "Calle 1",
                Rol = "Comprador"
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            // Prueba
            var controller = ConstruirUsuarioController();
            var respuesta = await controller.GetUsuario(idUsuario);

            // Verificación
            Assert.NotNull(respuesta);
            Assert.IsType<ActionResult<Usuario>>(respuesta);
        }

        [Fact]
        public async Task ObtenerUsuarioNoExistente()
        {
            // Preparación
            var idUsuarioNoExistente = Guid.NewGuid();

            // Prueba
            var controller = ConstruirUsuarioController();
            var respuesta = await controller.GetUsuario(idUsuarioNoExistente);

            // Verificación
            Assert.NotNull(respuesta);
            Assert.IsType<ActionResult<Usuario>>(respuesta);
            var resultado = Assert.IsType<NotFoundResult>(respuesta.Result);
            Assert.Equal(404, resultado.StatusCode);
        }

        private UsuarioController ConstruirUsuarioController()
        {
            return new UsuarioController(_configuration, _context);
        }
    }
}

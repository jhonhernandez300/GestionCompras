using LionDev.Models;
using System.Security.Claims;
using LionDev;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Backend.Utils
{
    public class Token
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor; // Agrega un campo para acceder a HttpContext

        public Token(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor; 
        }

        public dynamic ObtenerToken()
        {
            var identity = _httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity; // Accede a HttpContext a través del HttpContextAccessor

            return Jwt.validarToken(identity, _context);           
        }

        public string ObtenerRol(dynamic token) 
        {
            Usuario usuario = token.result;
            return usuario.Rol != "Administrador" ? "Comprador" : "Administrador";
        }
    }
}
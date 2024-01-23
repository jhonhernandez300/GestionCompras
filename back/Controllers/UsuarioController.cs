﻿using LionDev.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Security.AccessControl;

namespace LionDev.Controllers
{    
    [ApiController]    
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {        
        public IConfiguration _configuration;

        public UsuarioController(IConfiguration configuration) 
        { 
            _configuration = configuration; 
        }

        [HttpPost]
        [Route("login")]
        public dynamic login([FromBody] Object optData)
        {
            var data = JsonConvert.DeserializeObject<dynamic>(optData.ToString());
            string user = data.usuario.ToString();
            string password = data.password.ToString();


            try
            {
                Usuario usuario = Usuario.DB()
                .Where(x => x.usuario == user && x.password == password)
                .FirstOrDefault();

                if (usuario == null)
                {
                    return new
                    {
                        success = false,
                        message = "Credenciales incorrectas",
                        result = ""
                    };
                }
        
                var jwt = _configuration.GetSection("Jwt")
                .Get<Jwt>();
                
                var claims = new[]
                {                    
                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),                    
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),                    
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("id", usuario.idUsuario),
                    new Claim("usuario", usuario.usuario)
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));                
                var singIng = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                        jwt.Issuer,
                        jwt.Audience,
                        claims,
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: singIng
                );

                return new
                {
                    success = true,
                    message = "exito",
                    result = new JwtSecurityTokenHandler().WriteToken(token)
                };
            }
            catch (Exception ex) 
            { 
                return ex.Message;
            }
        }

      
    }
}
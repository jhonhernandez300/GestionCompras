using System.ComponentModel.DataAnnotations;

namespace LionDev.Models
{
    public class Usuario
    {
        public required Guid IdUsuario { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para los nombres es 30")]
        public required string Nombres { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para los apellidos es 30")]
        public required string Apellidos { get; set; }

        [StringLength(30, ErrorMessage = "Longitud máxima para el correo es 30")]
        public required string CorreoElectronico { get; set; }

        [StringLength(12, ErrorMessage = "Longitud máxima para el password es 12")]
        public required string Password { get; set; }

        [StringLength(13, ErrorMessage = "Longitud máxima para el password es 13")]
        public  string Rol { get; set; }             
    }
}

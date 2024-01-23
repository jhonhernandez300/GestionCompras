using System;

namespace LionDev.Models
{
    public class Comprador
    {
        public required Guid IdComprador { get; set; }
        //longitud mínima 3, máxima 30
        public required string Nombres { get; set; }
        //longitud mínima 3, máxima 30
        public required string Apellidos { get; set; }
        //longitud mínima 9, máxima 30
        public required string CorreoElectronico { get; set; }        
        public required string TipoDeDocumento { get; set; }
        //longitud mínima 5, máxima 16
        public required int NumeroDeDocumento { get; set; }
        //longitud mínima 8, máxima 30
        public required string Contrasena { get; set; }
        public string? Genero { get; set; }
        //longitud mínima 7, máxima 30
        public required string Direccion { get; set; }

        public ICollection<Factura>? Factura { get; set; }
    }
}

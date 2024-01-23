﻿namespace LionDev.Models
{
    public class Producto
    {
        public Guid IdProducto { get; set; } 
        public required string  Nombre { get; set;}
        public required string Referencia { get; set; }
        public string? Imagen { get; set; }
        public string? Descripcion { get; set; }
        public string? Color { get; set; }
        public required int Cantidad { get; set; }
        public required string Talla { get; set; }
        public required decimal Valor { get; set; }

        public Guid IdMarca { get; set; }
        public required Marca Marcas { get; set; }
    }
}

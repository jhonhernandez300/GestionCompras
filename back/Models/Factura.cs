namespace LionDev.Models
{
    public class Factura
    {
        public Guid IdFactura { get; set; }
        public required decimal Valor { get; set; }
        public required DateTime FechaYHora { get; set; }
        public required bool Pagado { get; set; }

        public Guid IdComprador { get; set; }
        public required Comprador Comprador { get; set; }

        public required ICollection<DetalleFactura> DetalleFactura { get; set; }
    }
}

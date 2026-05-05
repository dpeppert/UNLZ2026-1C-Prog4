using System.ComponentModel.DataAnnotations;

namespace Web.Data.Tables
{
    public class CompraDetalle
    {
        [Key]
        public int IdCompraDetalle { get; set; }
        public int IdCompra { get; set; }
        public int FechaTicket { get; set; }
        public decimal? ImporteUnitario { get; set; }

    }
}

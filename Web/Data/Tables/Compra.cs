using System.ComponentModel.DataAnnotations;

namespace Web.Data.Tables
{
    public class Compra 
    {
        [Key]
        public int IdCompra { get; set; }
        public int IdEvento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCompra { get; set; }

        public Audit? Audit { get; set; }
    }
}

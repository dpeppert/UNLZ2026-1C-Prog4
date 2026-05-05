using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;

namespace Web.Data.Tables
{
    public class ConfiguracionEvento
    {

        [Key]
        public int IdConfiguracionEvento { get; set; }
        public int IdEvento { get; set; }
        public int CantidadEntradas { get; set; }
        public DateTime FechaLimiteCompraEntradas { get; set; }

    }
}

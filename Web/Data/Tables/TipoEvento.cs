using System.ComponentModel.DataAnnotations;

namespace Web.Data.Tables
{
    public class TipoEvento
    {
        [Key]
        public int IdTipoEvento { get; set; }
        [MaxLength(50)]
        public string Descripcion { get; set; }

    }
}

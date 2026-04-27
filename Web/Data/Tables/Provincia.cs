using System.ComponentModel.DataAnnotations;

namespace Web.Data.Tables
{
    public class Provincia
    {

        [Key]
        public int IdProvincia { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }
    }
}

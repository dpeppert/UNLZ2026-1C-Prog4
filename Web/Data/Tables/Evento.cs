using System.ComponentModel.DataAnnotations;

namespace Web.Data.Tables
{
    public class Evento
    {

        [Key]
        public int IdEvento { get; set; }
        [MaxLength(100)]
        public string NombreEvento { get; set; }

        public DateTime FechaEvento { get; set; }


        public int? IdProvincia { get; set; }
        public Provincia? Provincia { get; set; }

        public int IdUbicacion { get; set; }

        public bool Activo { get; set; }

    }
}

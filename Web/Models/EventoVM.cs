using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class EventoVM
    {
        [Key]
        public int IdEvento { get; set; }

        [MaxLength(100)]
        public string NombreEvento { get; set; }

        public DateTime FechaEvento { get; set; }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Models
{
    public class EventoVM
    { 
    
        public int IdEvento { get; set; }

        public string NombreEvento { get; set; }

        public DateTime FechaEvento { get; set; }
    }
}

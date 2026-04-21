using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<EventoVM> Eventos { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using Web.Data.Tables;
using Web.Models;

namespace Web.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<EventoVM> Eventos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        // Ensure this constructor exists
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }
}

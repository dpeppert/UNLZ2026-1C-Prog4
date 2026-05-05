using Microsoft.EntityFrameworkCore;
using Web.Data.Tables;
using Web.Models;

namespace Web.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<TipoEvento> TiposEvento { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraDetalle> CompraDetalles { get; set; }
        public DbSet<ConfiguracionEvento> ConfiguracionesEvento { get; set; }

        // Ensure this constructor exists
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Compra>().OwnsOne(c => c.Audit);

            modelBuilder.Entity<Evento>().HasOne(x => x.Provincia);
        }

    }
}

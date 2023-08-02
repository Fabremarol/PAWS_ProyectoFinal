using Microsoft.EntityFrameworkCore;

namespace PAWS_ProyectoFinal.Models
{
    public class PAWSContext : DbContext
    {
        public PAWSContext(DbContextOptions<PAWSContext> opciones) 
            :base(opciones) 
        {
        
        }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Reporte> Reporte { get; set; }
    }
}

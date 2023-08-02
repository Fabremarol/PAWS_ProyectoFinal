using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAWS_ProyectoFinal.Models
{
    public class Producto
    {
        
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public int StockProducto { get; set; }
        public bool EstadoProducto { get; set; }
        public string ImagenProducto { get; set; }
        public List<Categoria> Categorias { get; set; }

    }
}

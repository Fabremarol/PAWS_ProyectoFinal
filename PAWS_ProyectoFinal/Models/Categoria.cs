namespace PAWS_ProyectoFinal.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public int Producto_ID { get; set; }
        public string NombreCategoria { get; set; }
        public Producto? Producto { get; set; }

    }
}

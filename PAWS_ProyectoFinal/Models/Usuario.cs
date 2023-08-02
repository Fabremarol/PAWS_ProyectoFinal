using System.ComponentModel.DataAnnotations;

namespace PAWS_ProyectoFinal.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public DateTime? UltimaConexion { get; set; }
        public bool EstadoUsuario { get; set; }

    }
}

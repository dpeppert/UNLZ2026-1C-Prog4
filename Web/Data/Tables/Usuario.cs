using System.ComponentModel.DataAnnotations;

namespace Web.Data.Tables
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}

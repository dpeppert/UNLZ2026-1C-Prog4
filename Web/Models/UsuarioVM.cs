using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class UsuarioVM
    {
        [DisplayName("Id del Usuario")]
        [Required]
        public int IdUsuario { get; set; }

        [StringLength(100)]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Range(10, 100)]
        public int Edad { get; set; }
        [EmailAddress(ErrorMessage = "Campo Incorrectamente cargado")]
        public string Email { get; set; }


       
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime? FechaNacimiento { get; set; }
    }
}

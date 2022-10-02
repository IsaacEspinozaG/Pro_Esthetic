//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Pro_Esthetic_CRUDCore.Models
{
    public class UsuariosModel
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string? Correo { get; set; }
    }
}

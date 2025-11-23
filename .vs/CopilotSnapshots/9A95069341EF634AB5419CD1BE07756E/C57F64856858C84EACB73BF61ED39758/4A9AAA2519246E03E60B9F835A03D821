
using System.ComponentModel.DataAnnotations;

namespace _02_CRUD.Modelos
{
    public class Rol_Model
    {
        [Key]
        public int Id_Rol { get; set; }

        [Required(ErrorMessage = "El nombre del rol es obligatorio")]
        [StringLength(50, MinimumLength = 3)]
        public string Nombre_Rol { get; set; }

        [Required(ErrorMessage = "La descripcion del rol es obligatoria")]
        public string Descripcion_Rol { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        public bool Estado_Rol { get; set; }

        // Propiedad de Navegación(Colección de Usuarios en este rol)
        public ICollection<Usuario_Model> Usuarios { get; set; }
    }
}

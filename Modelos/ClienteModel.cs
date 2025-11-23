using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _02_CRUD.Modelos
{
    public class ClienteModel
    {
        public int id { get; set; }
        //Aqui
        [Required(ErrorMessage = "El campo es obligatorio")]
        [Length(3, 50, ErrorMessage = "El numero de carateres esta entre 3 y 100")]
        public string Nombres { get; set; }
        //Hasta aqui

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string RUC { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Correo { get; set; }

        public bool Estado { get; set; }

        [NotMapped]
        public string Nombre_Completo { get; set; }
    }
}

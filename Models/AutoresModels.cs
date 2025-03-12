using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class AutoresModels
    {
        [Key]
        public int AutorId { get; set; }  // Primary Key

        [Required(ErrorMessage = "El nombre del autor es requerido.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del autor es requerido.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento del autor es requerida.")]
        [DataType(DataType.Date)]  // Asegura que solo se almacene la fecha, no la hora.
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "La nacionalidad del autor es requerida.")]
        public string Nacionalidad { get; set; }

        ///// Relaciones con Libros
        public ICollection<LibrosModels> Libros { get; set; }  // Relación 1:N con Libros
    }
}

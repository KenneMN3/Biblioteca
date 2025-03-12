using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class LibrosModels
    {
        [Key]
        public int LibroId { get; set; }  // Primary Key

        [Required(ErrorMessage = "El título del libro es requerido.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El género del libro es requerido.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "La fecha de publicación es requerida.")]
        [DataType(DataType.Date)]
        public DateOnly FechaPublicacion { get; set; }

        [Required(ErrorMessage = "El ISBN es requerido.")]
        public string ISBN { get; set; }

        ///// Relaciones con Autor
        [ForeignKey("AutorId")]
        public int AutorId { get; set; }  // Foreign Key a AutoresModels

        public AutoresModels Autor { get; set; }  // Relación N:1 con Autores
    }
}

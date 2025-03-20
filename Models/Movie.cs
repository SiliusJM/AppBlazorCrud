using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es requerido.")] // Campo requerido
        [StringLength(100, ErrorMessage = "El título no puede tener más de 100 caracteres.")] // Longitud máxima
        public string? Title { get; set; }

        [Required(ErrorMessage = "La fecha de publicación es requerida.")] // Campo requerido
        public DateOnly ReleaseDate { get; set; }

        [Required(ErrorMessage = "El género es requerido.")] // Campo requerido
        public string? Genre { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")] // Campo requerido
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0.")] // Rango válido
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

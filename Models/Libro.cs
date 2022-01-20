using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Libreria.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El titulo es requerido")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El año es requerido")]
        public string Anio { get; set; }
        [Required(ErrorMessage = "El genero es requerido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El número de paginas es requerido")]
        public int NumPaginas { get; set; }
        [Required(ErrorMessage = "La editorial es requerida")]
        public int? IdEditorial { get; set; }
        [Required(ErrorMessage = "El autor es requerido")]
        public int? IdAutor { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Editorial Editorial { get; set; }
    }
}

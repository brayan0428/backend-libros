using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Libreria.Models
{
    public partial class Autor
    {
        public Autor()
        {
            Libros = new HashSet<Libro>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "La ciudad es requerida")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}

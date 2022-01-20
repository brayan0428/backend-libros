using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Libreria.Models
{
    public partial class Editorial
    {
        public Editorial()
        {
            Libros = new HashSet<Libro>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La dirección es requerida")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El email es requerido")]
        public string Email { get; set; }
        public int? MaximoLibros { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}

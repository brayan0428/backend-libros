using Libreria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly LibreriaContext _context;

        public LibroController(LibreriaContext context)
        {
            _context = context;
        }
        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            var libros = _context.Libro.ToList();
            return libros;
        }

        // POST api/<LibroController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Libro libro)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Autor.Any(a => a.Id == libro.IdAutor)) return BadRequest("El autor no está registrado");
                if (!_context.Editorial.Any(e => e.Id == libro.IdEditorial)) return BadRequest("El editorial no está registrado");
                var editorial = await _context.Editorial.FindAsync(libro.IdEditorial);
                var cantidadLibrosActuales = _context.Libro.Where(l => l.IdEditorial == libro.IdEditorial).ToList().Count();
                if (cantidadLibrosActuales + 1 > editorial.MaximoLibros) return BadRequest("No es posible registrar el libro, se alcanzó el máximo permitido");
                _context.Libro.Add(libro);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        [Route("search/{parametro}")]
        public IEnumerable<Libro> BuscarLibros(string parametro)
        {
            var libros = _context.Libro
                .Include(l => l.Autor)
                .Where(l => l.Titulo.Contains(parametro) || l.Autor.Nombre.Contains(parametro) || l.Anio.Contains(parametro))
                .ToList();
            return libros;
        }
    }
}

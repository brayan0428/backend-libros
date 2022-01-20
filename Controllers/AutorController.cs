using Libreria.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly LibreriaContext _context;

        public AutorController(LibreriaContext context)
        {
            _context = context;
        }
        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            var autores = _context.Autor.ToList();
            return autores;
        }

        // POST api/<LibroController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Autor autor)
        {
            if (ModelState.IsValid)
            {
                _context.Autor.Add(autor);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}

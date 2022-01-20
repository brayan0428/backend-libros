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
    public class EditorialController : ControllerBase
    {
        private readonly LibreriaContext _context;

        public EditorialController(LibreriaContext context)
        {
            _context = context;
        }
        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Editorial> Get()
        {
            var editoriales = _context.Editorial.ToList();
            return editoriales;
        }

        // POST api/<LibroController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Editorial editorial)
        {
            if (ModelState.IsValid)
            {
                if (editorial.MaximoLibros == null)
                {
                    editorial.MaximoLibros = -1;
                }
                _context.Editorial.Add(editorial);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}

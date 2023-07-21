using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestDevBackend.Models;

namespace TestDevBackend.Controllers
{
    public class librosController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public librosController(ApplicationDbContext dbContext) { 
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<libros>>> GetLibros()
        {
            return await _dbContext.Libros.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<libros>> GetLibros(int id)
        {
            var producto = await _dbContext.Libros.FindAsync(id);

            if (producto == null)
                return NotFound();

            return producto;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestDevBackend.Models;

namespace TestDevBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    // Controlador para gestionar los autores
    public class autoresController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public autoresController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<autores>>> GetAutores()
        {
            return await _dbContext.Autores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<autores>> GetAutores(int id)
        {
            var autor = await _dbContext.Autores.FindAsync(id);

            if (autor == null)
                return NotFound();

            return autor;
        }
    }
}

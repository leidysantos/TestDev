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

    // Controlador para gestionar los editoriales
    public class editorialesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public editorialesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<editoriales>>> GetEditoriales()
        {
            return await _dbContext.Editoriales.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<editoriales>> GetEditoriales(int id)
        {
            var editorial = await _dbContext.Editoriales.FindAsync(id);

            if (editorial == null)
                return NotFound();

            return editorial;
        }
    }
}

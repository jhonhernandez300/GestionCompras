using LionDev;
using LionDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public IConfiguration _configuration;
        private ApplicationDbContext _context;

        public ProductoController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        // GET: Producto/GetByName/{name}
        [HttpGet("GetByName/{name}")]
        public async Task<ActionResult<IEnumerable<Producto>>> GetByName(string name)
        {
            var productos = await _context.Productos
                            .Where(p => p.Nombre == name)
                            .ToListAsync();

            if (productos == null || !productos.Any())
            {
                return NotFound();
            }

            return productos;
        }

        // GET: Producto/GetById/{id}
        [HttpGet("GetById/{id}")]
        public ActionResult<Producto> GetById(string id)
        {
            Guid guidValue;
            if (!Guid.TryParse(id, out guidValue))
            {                
                return BadRequest("El ID no es un Guid válido");
            }

            var producto = _context.Productos
                                .FirstOrDefault(p => p.IdProducto == guidValue);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // GET: Producto/GetMasBuscados/{paraSexo}
        [HttpGet("GetMasBuscados/{paraSexo}")]
        public async Task<ActionResult<IEnumerable<Producto>>> GetGetMasBuscados(string paraSexo)
        {
            var productos = await _context.Productos
                            .Where(p => p.EsDeLosMasBuscados == true && p.ParaSexo == paraSexo)
                            .ToListAsync();

            if (productos == null || !productos.Any())
            {
                return NotFound();
            }

            return productos;
        }
    }
}

using LionDev;
using LionDev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("Comprador")]
    public class CompradorController : ControllerBase
    {
        public IConfiguration _configuration;
        private ApplicationDbContext _context;

        public CompradorController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        // GET: Comprador/Compradores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comprador>>> GetCompradores()
        {
            return await _context.Compradores.ToListAsync();
        }

        // GET: Comprador/Compradores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comprador>> GetComprador(Guid id)
        {
            var comprador = await _context.Compradores.FindAsync(id);

            if (comprador == null)
            {
                return NotFound();
            }

            return comprador;
        }

        // POST: Comprador/Guardar
        [HttpPost]
        [Route("Guardar")]
        public async Task<ActionResult<Comprador>> Guardar([FromBody] Comprador comprador)
        {
            try
            {
                comprador.IdComprador = new Guid();
                _context.Compradores.Add(comprador);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetComprador), new { id = comprador.IdComprador }, comprador);
            }
            catch (Exception ex)
            {                
                return BadRequest($"Error al crear el comprador: {ex.Message}");
            }
        }

        // PUT: Comprador/Compradores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComprador(Guid id, Comprador comprador)
        {
            if (id != comprador.IdComprador)
            {
                return BadRequest();
            }

            _context.Entry(comprador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompradorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: Comprador/Compradores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComprador(Guid id)
        {
            var comprador = await _context.Compradores.FindAsync(id);
            if (comprador == null)
            {
                return NotFound();
            }

            _context.Compradores.Remove(comprador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompradorExists(Guid id)
        {
            return _context.Compradores.Any(e => e.IdComprador == id);
        }
    }
}

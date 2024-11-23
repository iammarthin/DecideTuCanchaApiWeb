using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DecidetucanchaWebApi.Context;

namespace DecidetucanchaWebApi.Controllers.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuscripcionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SuscripcionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Suscripcions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Suscripcion>>> GetSuscripciones()
        {
            return await _context.Suscripciones.ToListAsync();
        }

        // GET: api/Suscripcions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Suscripcion>> GetSuscripcion(int id)
        {
            var suscripcion = await _context.Suscripciones.FindAsync(id);

            if (suscripcion == null)
            {
                return NotFound();
            }

            return suscripcion;
        }

        // PUT: api/Suscripcions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuscripcion(int id, Suscripcion suscripcion)
        {
            if (id != suscripcion.SuscripcionID)
            {
                return BadRequest();
            }

            _context.Entry(suscripcion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuscripcionExists(id))
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

        // POST: api/Suscripcions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Suscripcion>> PostSuscripcion(Suscripcion suscripcion)
        {
            _context.Suscripciones.Add(suscripcion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSuscripcion", new { id = suscripcion.SuscripcionID }, suscripcion);
        }

        // DELETE: api/Suscripcions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSuscripcion(int id)
        {
            var suscripcion = await _context.Suscripciones.FindAsync(id);
            if (suscripcion == null)
            {
                return NotFound();
            }

            _context.Suscripciones.Remove(suscripcion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SuscripcionExists(int id)
        {
            return _context.Suscripciones.Any(e => e.SuscripcionID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DecidetucanchaWebApi.Context;
using DecidetucanchaWebApi.Controllers.Models;

namespace DecidetucanchaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplejoesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ComplejoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Complejoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Complejo>>> GetComplejos()
        {
            return await _context.Complejos.ToListAsync();
        }

        // GET: api/Complejoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Complejo>> GetComplejo(int id)
        {
            var complejo = await _context.Complejos.FindAsync(id);

            if (complejo == null)
            {
                return NotFound();
            }

            return complejo;
        }

        // PUT: api/Complejoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplejo(int id, Complejo complejo)
        {
            if (id != complejo.ComplejoID)
            {
                return BadRequest();
            }

            _context.Entry(complejo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplejoExists(id))
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

        // POST: api/Complejoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Complejo>> PostComplejo(Complejo complejo)
        {
            _context.Complejos.Add(complejo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplejo", new { id = complejo.ComplejoID }, complejo);
        }

        // DELETE: api/Complejoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplejo(int id)
        {
            var complejo = await _context.Complejos.FindAsync(id);
            if (complejo == null)
            {
                return NotFound();
            }

            _context.Complejos.Remove(complejo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComplejoExists(int id)
        {
            return _context.Complejos.Any(e => e.ComplejoID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationsAPI.Models;

namespace ReservationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstablishmentsController : ControllerBase
    {
        private readonly ReservationContext _context;

        public EstablishmentsController(ReservationContext context)
        {
            _context = context;
        }

        // GET: api/Establishments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Establishment>>> GetEstablishment()
        {
            return await _context.Establishment.ToListAsync();
        }

        // GET: api/Establishments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Establishment>> GetEstablishment(int id)
        {
            var establishment = await _context.Establishment.FindAsync(id);

            if (establishment == null)
            {
                return NotFound();
            }

            return establishment;
        }

        // PUT: api/Establishments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstablishment(int id, Establishment establishment)
        {
            if (id != establishment.ID)
            {
                return BadRequest();
            }

            _context.Entry(establishment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablishmentExists(id))
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

        // POST: api/Establishments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Establishment>> PostEstablishment(Establishment establishment)
        {
            _context.Establishment.Add(establishment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstablishment", new { id = establishment.ID }, establishment);
        }

        // DELETE: api/Establishments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstablishment(int id)
        {
            var establishment = await _context.Establishment.FindAsync(id);
            if (establishment == null)
            {
                return NotFound();
            }

            _context.Establishment.Remove(establishment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstablishmentExists(int id)
        {
            return _context.Establishment.Any(e => e.ID == id);
        }
    }
}

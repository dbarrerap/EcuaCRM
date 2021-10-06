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
    public class EstabContactsController : ControllerBase
    {
        private readonly ReservationsContext _context;

        public EstabContactsController(ReservationsContext context)
        {
            _context = context;
        }

        // GET: api/EstabContacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstablishmentContact>>> GetEstablishmentContact()
        {
            return await _context.EstablishmentContact.ToListAsync();
        }

        // GET: api/EstabContacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstablishmentContact>> GetEstablishmentContact(int id)
        {
            var establishmentContact = await _context.EstablishmentContact.FindAsync(id);

            if (establishmentContact == null)
            {
                return NotFound();
            }

            return establishmentContact;
        }

        // PUT: api/EstabContacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstablishmentContact(int id, EstablishmentContact establishmentContact)
        {
            if (id != establishmentContact.ID)
            {
                return BadRequest();
            }

            _context.Entry(establishmentContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablishmentContactExists(id))
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

        // POST: api/EstabContacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstablishmentContact>> PostEstablishmentContact(EstablishmentContact establishmentContact)
        {
            _context.EstablishmentContact.Add(establishmentContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstablishmentContact", new { id = establishmentContact.ID }, establishmentContact);
        }

        // DELETE: api/EstabContacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstablishmentContact(int id)
        {
            var establishmentContact = await _context.EstablishmentContact.FindAsync(id);
            if (establishmentContact == null)
            {
                return NotFound();
            }

            _context.EstablishmentContact.Remove(establishmentContact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstablishmentContactExists(int id)
        {
            return _context.EstablishmentContact.Any(e => e.ID == id);
        }
    }
}

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
    public class ProvContactsController : ControllerBase
    {
        private readonly ReservationsContext _context;

        public ProvContactsController(ReservationsContext context)
        {
            _context = context;
        }

        // GET: api/ProvContacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProviderContact>>> GetProviderContact()
        {
            return await _context.ProviderContact.ToListAsync();
        }

        // GET: api/ProvContacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProviderContact>> GetProviderContact(int id)
        {
            var providerContact = await _context.ProviderContact.FindAsync(id);

            if (providerContact == null)
            {
                return NotFound();
            }

            return providerContact;
        }

        // PUT: api/ProvContacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProviderContact(int id, ProviderContact providerContact)
        {
            if (id != providerContact.ID)
            {
                return BadRequest();
            }

            _context.Entry(providerContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderContactExists(id))
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

        // POST: api/ProvContacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProviderContact>> PostProviderContact(ProviderContact providerContact)
        {
            _context.ProviderContact.Add(providerContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProviderContact", new { id = providerContact.ID }, providerContact);
        }

        // DELETE: api/ProvContacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProviderContact(int id)
        {
            var providerContact = await _context.ProviderContact.FindAsync(id);
            if (providerContact == null)
            {
                return NotFound();
            }

            _context.ProviderContact.Remove(providerContact);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProviderContactExists(int id)
        {
            return _context.ProviderContact.Any(e => e.ID == id);
        }
    }
}

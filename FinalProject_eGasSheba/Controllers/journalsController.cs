using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.accounts;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class journalsController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public journalsController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/journals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<journal>>> Getjournal()
        {
            return await _context.journal.ToListAsync();
        }

        // GET: api/journals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<journal>> Getjournal(int id)
        {
            var journal = await _context.journal.FindAsync(id);

            if (journal == null)
            {
                return NotFound();
            }

            return journal;
        }

        // PUT: api/journals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putjournal(int id, journal journal)
        {
            if (id != journal.jnalID)
            {
                return BadRequest();
            }

            _context.Entry(journal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!journalExists(id))
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

        // POST: api/journals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<journal>> Postjournal(journal journal)
        {
            _context.journal.Add(journal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getjournal", new { id = journal.jnalID }, journal);
        }

        // DELETE: api/journals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletejournal(int id)
        {
            var journal = await _context.journal.FindAsync(id);
            if (journal == null)
            {
                return NotFound();
            }

            _context.journal.Remove(journal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool journalExists(int id)
        {
            return _context.journal.Any(e => e.jnalID == id);
        }
    }
}

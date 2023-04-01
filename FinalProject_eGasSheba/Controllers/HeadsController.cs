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
    public class HeadsController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public HeadsController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/Heads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Head>>> Gethead()
        {
            return await _context.head.ToListAsync();
        }

        // GET: api/Heads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Head>> GetHead(int id)
        {
            var head = await _context.head.FindAsync(id);

            if (head == null)
            {
                return NotFound();
            }

            return head;
        }

        // PUT: api/Heads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHead(int id, Head head)
        {
            if (id != head.hNameID)
            {
                return BadRequest();
            }

            _context.Entry(head).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeadExists(id))
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

        // POST: api/Heads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Head>> PostHead(Head head)
        {
            _context.head.Add(head);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHead", new { id = head.hNameID }, head);
        }

        // DELETE: api/Heads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHead(int id)
        {
            var head = await _context.head.FindAsync(id);
            if (head == null)
            {
                return NotFound();
            }

            _context.head.Remove(head);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HeadExists(int id)
        {
            return _context.head.Any(e => e.hNameID == id);
        }
    }
}

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
    public class cashesController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public cashesController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/cashes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<cash>>> Getcash()
        {
            return await _context.cash.ToListAsync();
        }

        // GET: api/cashes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<cash>> Getcash(int id)
        {
            var cash = await _context.cash.FindAsync(id);

            if (cash == null)
            {
                return NotFound();
            }

            return cash;
        }

        // PUT: api/cashes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcash(int id, cash cash)
        {
            if (id != cash.cashID)
            {
                return BadRequest();
            }

            _context.Entry(cash).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cashExists(id))
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

        // POST: api/cashes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<cash>> Postcash(cash cash)
        {
            _context.cash.Add(cash);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcash", new { id = cash.cashID }, cash);
        }

        // DELETE: api/cashes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletecash(int id)
        {
            var cash = await _context.cash.FindAsync(id);
            if (cash == null)
            {
                return NotFound();
            }

            _context.cash.Remove(cash);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool cashExists(int id)
        {
            return _context.cash.Any(e => e.cashID == id);
        }
    }
}

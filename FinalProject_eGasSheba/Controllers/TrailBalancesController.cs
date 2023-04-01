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
    public class TrailBalancesController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public TrailBalancesController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/TrailBalances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrailBalance>>> GettrialBalance()
        {
            return await _context.trialBalance.ToListAsync();
        }

        // GET: api/TrailBalances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrailBalance>> GetTrailBalance(int id)
        {
            var trailBalance = await _context.trialBalance.FindAsync(id);

            if (trailBalance == null)
            {
                return NotFound();
            }

            return trailBalance;
        }

        // PUT: api/TrailBalances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrailBalance(int id, TrailBalance trailBalance)
        {
            if (id != trailBalance.trBlnceId)
            {
                return BadRequest();
            }

            _context.Entry(trailBalance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrailBalanceExists(id))
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

        // POST: api/TrailBalances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TrailBalance>> PostTrailBalance(TrailBalance trailBalance)
        {
            _context.trialBalance.Add(trailBalance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrailBalance", new { id = trailBalance.trBlnceId }, trailBalance);
        }

        // DELETE: api/TrailBalances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrailBalance(int id)
        {
            var trailBalance = await _context.trialBalance.FindAsync(id);
            if (trailBalance == null)
            {
                return NotFound();
            }

            _context.trialBalance.Remove(trailBalance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrailBalanceExists(int id)
        {
            return _context.trialBalance.Any(e => e.trBlnceId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.stock;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class cylinderReturnsController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public cylinderReturnsController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/cylinderReturns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<cylinderReturn>>> GetcylinderReturn()
        {
            return await _context.cylinderReturn.ToListAsync();
        }

        // GET: api/cylinderReturns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<cylinderReturn>> GetcylinderReturn(int id)
        {
            var cylinderReturn = await _context.cylinderReturn.FindAsync(id);

            if (cylinderReturn == null)
            {
                return NotFound();
            }

            return cylinderReturn;
        }

        // PUT: api/cylinderReturns/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutcylinderReturn(int id, cylinderReturn cylinderReturn)
        {
            if (id != cylinderReturn.cylinderReturnID)
            {
                return BadRequest();
            }

            _context.Entry(cylinderReturn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cylinderReturnExists(id))
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

        // POST: api/cylinderReturns
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<cylinderReturn>> PostcylinderReturn(cylinderReturn cylinderReturn)
        {
            _context.cylinderReturn.Add(cylinderReturn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetcylinderReturn", new { id = cylinderReturn.cylinderReturnID }, cylinderReturn);
        }

        // DELETE: api/cylinderReturns/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletecylinderReturn(int id)
        {
            var cylinderReturn = await _context.cylinderReturn.FindAsync(id);
            if (cylinderReturn == null)
            {
                return NotFound();
            }

            _context.cylinderReturn.Remove(cylinderReturn);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool cylinderReturnExists(int id)
        {
            return _context.cylinderReturn.Any(e => e.cylinderReturnID == id);
        }
    }
}

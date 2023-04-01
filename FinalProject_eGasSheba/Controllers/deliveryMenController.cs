using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.technician_Delivary;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class deliveryMenController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public deliveryMenController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/deliveryMen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<deliveryMan>>> GetdeliveryMan()
        {
            return await _context.deliveryMan.ToListAsync();
        }

        // GET: api/deliveryMen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<deliveryMan>> GetdeliveryMan(int id)
        {
            var deliveryMan = await _context.deliveryMan.FindAsync(id);

            if (deliveryMan == null)
            {
                return NotFound();
            }

            return deliveryMan;
        }

        // PUT: api/deliveryMen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutdeliveryMan(int id, deliveryMan deliveryMan)
        {
            if (id != deliveryMan.delID)
            {
                return BadRequest();
            }

            _context.Entry(deliveryMan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!deliveryManExists(id))
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

        // POST: api/deliveryMen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<deliveryMan>> PostdeliveryMan(deliveryMan deliveryMan)
        {
            _context.deliveryMan.Add(deliveryMan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetdeliveryMan", new { id = deliveryMan.delID }, deliveryMan);
        }

        // DELETE: api/deliveryMen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletedeliveryMan(int id)
        {
            var deliveryMan = await _context.deliveryMan.FindAsync(id);
            if (deliveryMan == null)
            {
                return NotFound();
            }

            _context.deliveryMan.Remove(deliveryMan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool deliveryManExists(int id)
        {
            return _context.deliveryMan.Any(e => e.delID == id);
        }
    }
}

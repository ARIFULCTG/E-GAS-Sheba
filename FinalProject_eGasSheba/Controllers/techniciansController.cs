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
    public class techniciansController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public techniciansController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/technicians
        [HttpGet]
        public async Task<ActionResult<IEnumerable<technician>>> Gettechnician()
        {
            return await _context.technician.ToListAsync();
        }

        // GET: api/technicians/5
        [HttpGet("{id}")]
        public async Task<ActionResult<technician>> Gettechnician(int id)
        {
            var technician = await _context.technician.FindAsync(id);

            if (technician == null)
            {
                return NotFound();
            }

            return technician;
        }

        // PUT: api/technicians/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Puttechnician(int id, technician technician)
        {
            if (id != technician.technicianID)
            {
                return BadRequest();
            }

            _context.Entry(technician).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!technicianExists(id))
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

        // POST: api/technicians
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<technician>> Posttechnician(technician technician)
        {
            _context.technician.Add(technician);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Gettechnician", new { id = technician.technicianID }, technician);
        }

        // DELETE: api/technicians/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetechnician(int id)
        {
            var technician = await _context.technician.FindAsync(id);
            if (technician == null)
            {
                return NotFound();
            }

            _context.technician.Remove(technician);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool technicianExists(int id)
        {
            return _context.technician.Any(e => e.technicianID == id);
        }
    }
}

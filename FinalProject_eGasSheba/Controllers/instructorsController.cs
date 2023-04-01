using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.training;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class instructorsController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public instructorsController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/instructors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<instructor>>> Getinstructor()
        {
            return await _context.instructor.ToListAsync();
        }

        // GET: api/instructors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<instructor>> Getinstructor(int id)
        {
            var instructor = await _context.instructor.FindAsync(id);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }

        // PUT: api/instructors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putinstructor(int id, instructor instructor)
        {
            if (id != instructor.instructorID)
            {
                return BadRequest();
            }

            _context.Entry(instructor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!instructorExists(id))
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

        // POST: api/instructors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<instructor>> Postinstructor(instructor instructor)
        {
            _context.instructor.Add(instructor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getinstructor", new { id = instructor.instructorID }, instructor);
        }

        // DELETE: api/instructors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteinstructor(int id)
        {
            var instructor = await _context.instructor.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }

            _context.instructor.Remove(instructor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool instructorExists(int id)
        {
            return _context.instructor.Any(e => e.instructorID == id);
        }
    }
}

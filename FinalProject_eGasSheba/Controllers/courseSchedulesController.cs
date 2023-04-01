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
    public class courseSchedulesController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public courseSchedulesController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/courseSchedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<courseSchedule>>> GetcourseSchedule()
        {
            return await _context.courseSchedule.ToListAsync();
        }

        // GET: api/courseSchedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<courseSchedule>> GetcourseSchedule(int id)
        {
            var courseSchedule = await _context.courseSchedule.FindAsync(id);

            if (courseSchedule == null)
            {
                return NotFound();
            }

            return courseSchedule;
        }

        // PUT: api/courseSchedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutcourseSchedule(int id, courseSchedule courseSchedule)
        {
            if (id != courseSchedule.slNO)
            {
                return BadRequest();
            }

            _context.Entry(courseSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!courseScheduleExists(id))
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

        // POST: api/courseSchedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<courseSchedule>> PostcourseSchedule(courseSchedule courseSchedule)
        {
            _context.courseSchedule.Add(courseSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetcourseSchedule", new { id = courseSchedule.slNO }, courseSchedule);
        }

        // DELETE: api/courseSchedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletecourseSchedule(int id)
        {
            var courseSchedule = await _context.courseSchedule.FindAsync(id);
            if (courseSchedule == null)
            {
                return NotFound();
            }

            _context.courseSchedule.Remove(courseSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool courseScheduleExists(int id)
        {
            return _context.courseSchedule.Any(e => e.slNO == id);
        }
    }
}

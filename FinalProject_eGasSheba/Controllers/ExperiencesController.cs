using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.product;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public ExperiencesController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/Experiences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Experience>>> Getexperiences()
        {
            return await _context.experiences.ToListAsync();
        }

        // GET: api/Experiences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Experience>> GetExperience(int id)
        {
            var experience = await _context.experiences.FindAsync(id);

            if (experience == null)
            {
                return NotFound();
            }

            return experience;
        }

        // PUT: api/Experiences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExperience(int id, Experience experience)
        {
            if (id != experience.experienceID)
            {
                return BadRequest();
            }

            _context.Entry(experience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExperienceExists(id))
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

        // POST: api/Experiences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Experience>> PostExperience(Experience experience)
        {
            _context.experiences.Add(experience);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExperience", new { id = experience.experienceID }, experience);
        }

        // DELETE: api/Experiences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperience(int id)
        {
            var experience = await _context.experiences.FindAsync(id);
            if (experience == null)
            {
                return NotFound();
            }

            _context.experiences.Remove(experience);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExperienceExists(int id)
        {
            return _context.experiences.Any(e => e.experienceID == id);
        }
    }
}

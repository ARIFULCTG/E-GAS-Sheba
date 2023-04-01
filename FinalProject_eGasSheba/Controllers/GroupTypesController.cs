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
    public class GroupTypesController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public GroupTypesController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/GroupTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupType>>> GetgroupType()
        {
            return await _context.groupType.ToListAsync();
        }

        // GET: api/GroupTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupType>> GetGroupType(int id)
        {
            var groupType = await _context.groupType.FindAsync(id);

            if (groupType == null)
            {
                return NotFound();
            }

            return groupType;
        }

        // PUT: api/GroupTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupType(int id, GroupType groupType)
        {
            if (id != groupType.groupId)
            {
                return BadRequest();
            }

            _context.Entry(groupType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupTypeExists(id))
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

        // POST: api/GroupTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GroupType>> PostGroupType(GroupType groupType)
        {
            _context.groupType.Add(groupType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGroupType", new { id = groupType.groupId }, groupType);
        }

        // DELETE: api/GroupTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroupType(int id)
        {
            var groupType = await _context.groupType.FindAsync(id);
            if (groupType == null)
            {
                return NotFound();
            }

            _context.groupType.Remove(groupType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GroupTypeExists(int id)
        {
            return _context.groupType.Any(e => e.groupId == id);
        }
    }
}

using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeptController : ControllerBase
    {
        AppDBcontext _dbContext;
        public DeptController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.depts.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Dept Dept)
        {
            var Depts = new Dept()
            {
                depID = Dept.depID,
                depName = Dept.depName


            };
            await _dbContext.depts.AddAsync(Dept);
            await _dbContext.SaveChangesAsync();

            return Ok(Dept);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, Dept Dept)
        {


            var entity = _dbContext.depts.FirstOrDefault(e => e.depID == id);
            entity.depName = Dept.depName;

            await _dbContext.SaveChangesAsync();

            return Ok(Dept);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Dept>> GetByID(int id)
        {
            var getId = await _dbContext.depts.FindAsync(id);

            if(getId == null)
            {
                return NotFound();
            }

            return getId;
        }
        // DELETE: api/cashes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var getId = await _dbContext.depts.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.depts.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

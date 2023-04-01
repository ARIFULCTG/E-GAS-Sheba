using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GenderController : ControllerBase
    {
        AppDBcontext _dbContext;
        public GenderController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.distributors.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Gender Gender)
        {
            var Distributors = new Gender()
            {
                Gid = Gender.Gid,
                Gender_Name = Gender.Gender_Name,


            };
            await _dbContext.genders.AddAsync(Gender);
            await _dbContext.SaveChangesAsync();

            return Ok(Gender);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, Gender Gender)
        {


            var entity = _dbContext.genders.FirstOrDefault(e => e.Gid == id);
            entity.Gender_Name = Gender.Gender_Name;

            await _dbContext.SaveChangesAsync();

            return Ok(Gender);
        }
       
        [HttpGet("{id}")]
        public async Task<ActionResult<Gender>> GetByID(int id)
        {
            var getId = await _dbContext.genders.FindAsync(id);

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
            var getId = await _dbContext.genders.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.genders.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

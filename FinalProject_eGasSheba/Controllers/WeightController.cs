using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeightController : ControllerBase
    {
        AppDBcontext _dbContext;
        public WeightController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.weights.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Weight Weight)
        {
            var Weights = new Weight()
            {
                wID = Weight.wID,
                weight1 = Weight.weight1,


            };
            await _dbContext.weights.AddAsync(Weight);
            await _dbContext.SaveChangesAsync();

            return Ok(Weight);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, Weight Weight)
        {


            var entity = _dbContext.weights.FirstOrDefault(e => e.wID == id);
            entity.weight1 = Weight.weight1;

            await _dbContext.SaveChangesAsync();

            return Ok(Weight);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Weight>> GetByID(int id)
        {
            var getId = await _dbContext.weights.FindAsync(id);

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
            var getId = await _dbContext.weights.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.weights.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

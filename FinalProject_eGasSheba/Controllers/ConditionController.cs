using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConditionController : ControllerBase
    {
        AppDBcontext _dbContext;
        public ConditionController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.conditions.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Condition Condition)
        {
            var conditions = new Condition()
            {
                coID = Condition.coID,
                conditionName = Condition.conditionName,
                Detail = Condition.Detail

            };
            await _dbContext.conditions.AddAsync(Condition);
            await _dbContext.SaveChangesAsync();

            return Ok(conditions);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, Condition Condition)
        {


            var entity = _dbContext.conditions.FirstOrDefault(e => e.coID == id);
            entity.conditionName = Condition.conditionName;
            entity.Detail = Condition.Detail;
            await _dbContext.SaveChangesAsync();

            return Ok(Condition);
        }
        //[HttpPost]
        //public async Task<IActionResult> Delete(int id, Condition Condition)
        //{
        //    _dbContext.conditions.Remove(_dbContext.conditions.FirstOrDefault(e => e.coID == id));

        //    await _dbContext.SaveChangesAsync();

        //    return Ok(Condition);

        //}
        //[HttpGet]
        //public async Task<IActionResult> GetByID(int id)
        //{
        //    var entity = _dbContext.conditions.FirstOrDefault(e => e.coID == id);
        //    if (entity != null)
        //    {
        //        //entity.cityName = city.cityName;

        //        //await _dbContext.SaveChangesAsync();
        //        //return Ok(entity);
        //        return Ok("Not Found");
        //    }
        //    return Ok(entity);
        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<Condition>> GetByID(int id)
        {
            var getId = await _dbContext.conditions.FindAsync(id);

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
            var getId = await _dbContext.conditions.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.conditions.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

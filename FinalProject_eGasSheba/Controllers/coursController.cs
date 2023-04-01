using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.training;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class coursController : ControllerBase
    {
        AppDBcontext _dbContext;
        public coursController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.course.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(cours cours)
        {
            var courses = new cours()
            {
                coureID = cours.coureID,
                courName = cours.courName
            };
            await _dbContext.course.AddAsync(cours);
            await _dbContext.SaveChangesAsync();

            return Ok(courses);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, cours cours)
        {


            var entity = _dbContext.course.FirstOrDefault(e => e.coureID == id);
            entity.courName = cours.courName;
            entity.durationday = cours.durationday;
            entity.price = cours.price;

            await _dbContext.SaveChangesAsync();

            return Ok(cours);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<cours>> GetByID(int id)
        {
            var getId = await _dbContext.course.FindAsync(id);

            if(getId == null)
            {
                return NotFound();
            }

            return getId;
        }
        // DELETE: api/cashes/5
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var a = _dbContext.course.FirstOrDefault(e => e.coureID == id);
            _dbContext.course.Remove(a);

            await _dbContext.SaveChangesAsync();

            return Ok(1);

        }

    }
}

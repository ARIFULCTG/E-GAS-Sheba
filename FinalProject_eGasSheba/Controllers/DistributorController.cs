using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DistributorController : ControllerBase
    {
        AppDBcontext _dbContext;
        public DistributorController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.distributors.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Distributor Distributor)
        {
            var Distributors = new Distributor()
            {
                dID = Distributor.dID,
                distributorName = Distributor.distributorName,


            };
            await _dbContext.distributors.AddAsync(Distributor);
            await _dbContext.SaveChangesAsync();

            return Ok(Distributor);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, Distributor Distributor)
        {


            var entity = _dbContext.distributors.FirstOrDefault(e => e.dID == id);
            entity.distributorName = Distributor.distributorName;

            await _dbContext.SaveChangesAsync();

            return Ok(Distributor);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Distributor>> GetByID(int id)
        {
            var getId = await _dbContext.distributors.FindAsync(id);

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
            var getId = await _dbContext.distributors.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.distributors.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

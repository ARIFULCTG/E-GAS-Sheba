using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class payment_typeController : ControllerBase
    {
        AppDBcontext _dbContext;
        public payment_typeController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.distributors.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(payment_type payment_type)
        {
            var payment_types = new payment_type()
            {
                paymentID = payment_type.paymentID,
                paymentName = payment_type.paymentName,


            };
            await _dbContext.payment_Types.AddAsync(payment_type);
            await _dbContext.SaveChangesAsync();

            return Ok(payment_type);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, payment_type payment_type)
        {


            var entity = _dbContext.payment_Types.FirstOrDefault(e => e.paymentID == id);
            entity.paymentName = payment_type.paymentName;

            await _dbContext.SaveChangesAsync();

            return Ok(payment_type);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<payment_type>> GetByID(int id)
        {
            var getId = await _dbContext.payment_Types.FindAsync(id);

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
            var getId = await _dbContext.payment_Types.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.payment_Types.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.technician_Delivary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class designationController : ControllerBase

    {
        AppDBcontext _dbContext;
        public designationController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.designations.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(designation designation)
        {
            var designations = new designation()
            {
                designationID = designation.designationID,
                designationName = designation.designationName
            };
            await _dbContext.designations.AddAsync(designation);
            await _dbContext.SaveChangesAsync();

            return Ok(designations);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<designation>> GetByID(int id)
        {
            var getId = await _dbContext.designations.FindAsync(id);

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
            var getId = await _dbContext.designations.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.designations.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update(int designationID, designation designation)
        {
            var entity = _dbContext.designations.FirstOrDefault(e => e.designationID == designationID);
            entity.designationName = designation.designationName;
           
            await _dbContext.SaveChangesAsync();

            return Ok(designation);
        }
    }
}



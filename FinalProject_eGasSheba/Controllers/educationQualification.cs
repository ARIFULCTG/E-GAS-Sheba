using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.technician_Delivary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class educationQualificationController : ControllerBase
    {
        AppDBcontext _dbContext;
        public educationQualificationController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.educationQualifications.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(educationQualification educationQualification)
        {
            var eq = new educationQualification()
            {
                eduQualificationID = educationQualification.eduQualificationID,
                qualificationName = educationQualification.qualificationName
            };
            await _dbContext.educationQualifications.AddAsync(educationQualification);
            await _dbContext.SaveChangesAsync();

            return Ok(eq);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<educationQualification>> GetByID(int id)
        {
            var getId = await _dbContext.educationQualifications.FindAsync(id);

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
            var getId = await _dbContext.educationQualifications.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.educationQualifications.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update(int eduQualificationID, educationQualification educationQualification)
        {
            var entity = _dbContext.educationQualifications.FirstOrDefault(e => e.eduQualificationID == eduQualificationID);
            entity.qualificationName = educationQualification.qualificationName;
            
            await _dbContext.SaveChangesAsync();

            return Ok(educationQualification);
        }
    }
}



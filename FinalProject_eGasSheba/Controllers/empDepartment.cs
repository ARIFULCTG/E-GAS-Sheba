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
    public class empDepartmentController : ControllerBase
    {
        AppDBcontext _dbContext;
        public empDepartmentController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.empDepartments.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(empDepartment empDepartment)
        {
            var ed = new empDepartment()
            {
                empDepID = empDepartment.empDepID,
                depName = empDepartment.depName
            };
            await _dbContext.empDepartments.AddAsync(empDepartment);
            await _dbContext.SaveChangesAsync();

            return Ok(ed);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<empDepartment>> GetByID(int id)
        {
            var getId = await _dbContext.empDepartments.FindAsync(id);

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
            var getId = await _dbContext.empDepartments.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.empDepartments.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update(int empDepID, empDepartment empDepartment)
        {
            var entity = _dbContext.empDepartments.FirstOrDefault(e => e.empDepID == empDepID);
            entity.depName = empDepartment.depName;

            await _dbContext.SaveChangesAsync();

            return Ok(empDepartment);
        }
    }
}




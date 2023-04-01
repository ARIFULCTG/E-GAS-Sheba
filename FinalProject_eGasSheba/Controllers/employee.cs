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
    public class employeeController : ControllerBase
    {
        AppDBcontext _dbContext;
        public employeeController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.employees.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(employee employee)
        {
            var em = new employee()
            {
                empID = employee.empID,
                empName = employee.empName,
                phone_01 = employee.phone_01,
                phone_02 = employee.phone_02,
                cityID = employee.cityID,
                aID = employee.aID,
                road_No = employee.road_No,
                house_No = employee.house_No,
                joinDate = employee.joinDate

            };
            await _dbContext.employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();

            return Ok(em);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<employee>> GetByID(int id)
        {
            var getId = await _dbContext.employees.FindAsync(id);

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
            var getId = await _dbContext.employees.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.employees.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update(int empID, employee employee)
        {
            var entity = _dbContext.employees.FirstOrDefault(e => e.empID == empID);
            entity.empName = employee.empName;
            entity.phone_01 = employee.phone_01;
            entity.phone_02 = employee.phone_02;
            entity.cityID = employee.cityID;
            entity.aID = employee.aID;
            entity.road_No = employee.road_No;
            entity.house_No = employee.house_No;
            entity.NID = employee.NID;
            entity.experience = employee.experience;
            entity.photo = employee.photo;

            await _dbContext.SaveChangesAsync();

            return Ok(employee);
        }
    }
}


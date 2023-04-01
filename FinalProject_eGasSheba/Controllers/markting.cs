using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.technician_Delivary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class marktingController : ControllerBase
    {
        AppDBcontext _dbContext;
        public marktingController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.marketings.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(markting markting)
        {
            var mr = new markting()
            {
                mktID = markting.mktID,
                today = markting.today,
                empID = markting.empID,
                campID = markting.campID,
                companyCustomer = markting.companyCustomer,
                cityID = markting.cityID,
                road_No = markting.road_No,
                house_No = markting.house_No,
                aID = markting.aID,
                phone = markting.phone,
                descriptions = markting.descriptions,
                valuation = markting.valuation,
                recomendation = markting.recomendation,
                nextVisit = markting.nextVisit,
                Terminate = markting.Terminate

            };
            await _dbContext.marketings.AddAsync(markting);
            await _dbContext.SaveChangesAsync();

            return Ok(mr);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<markting>> GetByID(int id)
        {
            var getId = await _dbContext.marketings.FindAsync(id);

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
            var getId = await _dbContext.marketings.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.marketings.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Update(int mktID, markting markting)
        {
            var entity = _dbContext.marketings.FirstOrDefault(e => e.mktID == mktID);
            entity.today = markting.today;
            entity.empID = markting.empID;
            entity.campID = markting.campID;
            entity.companyCustomer = markting.companyCustomer;
            entity.cityID = markting.cityID;
            entity.road_No = markting.road_No;
            entity.aID = markting.aID;
            entity.road_No = markting.road_No;
            entity.house_No = markting.house_No;
            entity.phone = markting.phone;
            entity.descriptions = markting.descriptions;
            entity.valuation = markting.valuation;
            entity.recomendation = markting.recomendation;
            entity.nextVisit = markting.nextVisit;
            entity.Terminate = markting.Terminate;

            await _dbContext.SaveChangesAsync();

            return Ok(markting);
        }
    }
}


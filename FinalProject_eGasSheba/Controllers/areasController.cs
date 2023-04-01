using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class areasController : ControllerBase
    {
        AppDBcontext _dbContext;
        private readonly City _city;
        public areasController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.areas.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Area Area)
        {
            var areas = new Area()
            {
                aID = Area.aID,
                areaName = Area.areaName,
                cityID = Area.cityID
                
            };
            await _dbContext.areas.AddAsync(Area);
            await _dbContext.SaveChangesAsync();

            return Ok(areas);

        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, Area Area)
        {


            var entity = _dbContext.areas.FirstOrDefault(e => e.aID == id);
            entity.areaName = Area.areaName;
            entity.cityID = Area.cityID;

            await _dbContext.SaveChangesAsync();

            return Ok(Area);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var a = _dbContext.areas.FirstOrDefault(e => e.aID == id);
            _dbContext.areas.Remove(a);

            await _dbContext.SaveChangesAsync();

            return Ok(1);


        }
        [HttpGet]
        public async Task<IActionResult> GetByID(int id)
        {
            var entity = _dbContext.areas.FirstOrDefault(e => e.aID == id);
            if (entity != null)
            {
                //entity.cityName = city.cityName;

                //await _dbContext.SaveChangesAsync();
                //return Ok(entity);
                return Ok("Not Found");
            }
            return Ok(entity);
        }
    }
}

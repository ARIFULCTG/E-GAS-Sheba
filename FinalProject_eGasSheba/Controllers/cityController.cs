using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.accounts;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace FinalProject_eGasSheba.Controllers.Child
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class cityController : ControllerBase
    {
        AppDBcontext _dbContext;
        public cityController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.cities.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(City city)
        {
            var cities = new City()
            {
                cityID = city.cityID,
                cityName = city.cityName
            };
            await _dbContext.cities.AddAsync(city);
            await _dbContext.SaveChangesAsync();

            return Ok(cities);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, City city)
        {


            var entity = _dbContext.cities.FirstOrDefault(e => e.cityID == id);
            entity.cityName = city.cityName;

            await _dbContext.SaveChangesAsync();

            return Ok(city);
        }
        //[HttpPost]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var a = _dbContext.cities.FirstOrDefault(e => e.cityID == id);
        //    _dbContext.areas.Remove(a);

        //    await _dbContext.SaveChangesAsync();

        //    return Ok(1);


        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCity(int id)
        {
            var cash = await _dbContext.cities.FindAsync(id);

            if(cash == null)
            {
                return NotFound();
            }

            return cash;
        }
        // DELETE: api/cashes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cash = await _dbContext.cities.FindAsync(id);
            if(cash == null)
            {
                return NotFound();
            }

            _dbContext.cities.Remove(cash);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }

}

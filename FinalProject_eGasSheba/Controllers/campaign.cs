using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using FinalProject_eGasSheba.Model.marketing;
using FinalProject_eGasSheba.Model.training;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_eGasSheba.Controllers
{ 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class campaignController: ControllerBase
    {
        AppDBcontext _dbContext;
        public campaignController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.campaigns.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(campaign campaign)
        {
            var camp = new campaign()
            {
                campID = campaign.campID,
                campName = campaign.campName
            };
            await _dbContext.campaigns.AddAsync(campaign);
            await _dbContext.SaveChangesAsync();

            return Ok(camp);

        }
       
            [HttpPost]
            public async Task<IActionResult> Delete(int campID, campaign campaign)
            {
                _dbContext.campaigns.Remove(_dbContext.campaigns.FirstOrDefault(e => e.campID == campID));

                await _dbContext.SaveChangesAsync();

                return Ok(campaign);

            }
            [HttpGet]
            public async Task<IActionResult> GetByID(int campID)
            {
                var entity = _dbContext.campaigns.FirstOrDefault(e => e.campID == campID);
                if (entity != null)
                {
                    //entity.cityName = city.cityName;

                    //await _dbContext.SaveChangesAsync();
                    //return Ok(entity);
                    return Ok("Not Found");
                }
                return Ok(entity);
            }
        [HttpPut]
        public async Task<IActionResult> Update(int campID, campaign campaign)
        {
            var entity = _dbContext.campaigns.FirstOrDefault(e => e.campID == campID);
            entity.campName = campaign.campName;
            //entity.courID = courseSchedule.courID;
            //entity.instructorID = courseSchedule.instructorID;
            //entity.date = courseSchedule.date;
            //entity.time = courseSchedule.time;


            await _dbContext.SaveChangesAsync();

            return Ok(campaign);
        }
    }
    }


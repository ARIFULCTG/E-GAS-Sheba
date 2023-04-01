using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.child;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Type = FinalProject_eGasSheba.Model.child.Type;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        AppDBcontext _dbContext;
        public TypeController(AppDBcontext dBcontext)
        {
            _dbContext = dBcontext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _dbContext.types.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Type Type)
        {
            var Types = new Type()
            {
                tID = Type.tID,
                typeName = Type.typeName,


            };
            await _dbContext.types.AddAsync(Type);
            await _dbContext.SaveChangesAsync();

            return Ok(Type);

        }
        [HttpPut]

        public async Task<IActionResult> Update(int id, Type Type)
        {


            var entity = _dbContext.types.FirstOrDefault(e => e.tID == id);
            entity.typeName = Type.typeName;

            await _dbContext.SaveChangesAsync();

            return Ok(Type);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Type>> GetByID(int id)
        {
            var getId = await _dbContext.types.FindAsync(id);

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
            var getId = await _dbContext.types.FindAsync(id);
            if(getId == null)
            {
                return NotFound();
            }

            _dbContext.types.Remove(getId);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}

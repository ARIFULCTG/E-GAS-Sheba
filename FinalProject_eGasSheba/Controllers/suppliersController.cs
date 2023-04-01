using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject_eGasSheba.Context;
using FinalProject_eGasSheba.Model.puechase;

namespace FinalProject_eGasSheba.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class suppliersController : ControllerBase
    {
        private readonly AppDBcontext _context;

        public suppliersController(AppDBcontext context)
        {
            _context = context;
        }

        // GET: api/suppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<supplier>>> Getsuppliers()
        {
            return await _context.suppliers.ToListAsync();
        }

        // GET: api/suppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<supplier>> Getsupplier(string id)
        {
            var supplier = await _context.suppliers.FindAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        // PUT: api/suppliers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putsupplier(string id, supplier supplier)
        {
            if (id != supplier.supplierID)
            {
                return BadRequest();
            }

            _context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!supplierExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/suppliers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<supplier>> Postsupplier(supplier supplier)
        {
            _context.suppliers.Add(supplier);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (supplierExists(supplier.supplierID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("Getsupplier", new { id = supplier.supplierID }, supplier);
        }

        // DELETE: api/suppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletesupplier(string id)
        {
            var supplier = await _context.suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            _context.suppliers.Remove(supplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool supplierExists(string id)
        {
            return _context.suppliers.Any(e => e.supplierID == id);
        }
    }
}

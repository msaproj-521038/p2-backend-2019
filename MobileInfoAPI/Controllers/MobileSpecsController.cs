using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileInfoAPI.Models;

namespace MobileInfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileSpecsController : ControllerBase
    {
        private readonly MobileInfoAPIContext _context;

        public MobileSpecsController(MobileInfoAPIContext context)
        {
            _context = context;
        }

        // GET: api/MobileSpecs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MobileSpecs>>> GetMobileSpecs()
        {
            return await _context.MobileSpecs.ToListAsync();
        }

        // GET: api/MobileSpecs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MobileSpecs>> GetMobileSpecs(int id)
        {
            var mobileSpecs = await _context.MobileSpecs.FindAsync(id);

            if (mobileSpecs == null)
            {
                return NotFound();
            }

            return mobileSpecs;
        }

        // PUT: api/MobileSpecs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMobileSpecs(int id, MobileSpecs mobileSpecs)
        {
            if (id != mobileSpecs.Id)
            {
                return BadRequest();
            }

            _context.Entry(mobileSpecs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobileSpecsExists(id))
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

        // POST: api/MobileSpecs
        [HttpPost]
        public async Task<ActionResult<MobileSpecs>> PostMobileSpecs(MobileSpecs mobileSpecs)
        {
            _context.MobileSpecs.Add(mobileSpecs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMobileSpecs", new { id = mobileSpecs.Id }, mobileSpecs);
        }

        // DELETE: api/MobileSpecs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MobileSpecs>> DeleteMobileSpecs(int id)
        {
            var mobileSpecs = await _context.MobileSpecs.FindAsync(id);
            if (mobileSpecs == null)
            {
                return NotFound();
            }

            _context.MobileSpecs.Remove(mobileSpecs);
            await _context.SaveChangesAsync();

            return mobileSpecs;
        }

        private bool MobileSpecsExists(int id)
        {
            return _context.MobileSpecs.Any(e => e.Id == id);
        }
    }
}

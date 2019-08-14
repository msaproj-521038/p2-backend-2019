using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTable.Models;

namespace PeriodicTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsController : ControllerBase
    {
        private readonly PeriodicTableContext _context;

        public ElementsController(PeriodicTableContext context)
        {
            _context = context;
        }

        // GET: api/Elements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Element>>> GetElements()
        {
            return await _context.Element.ToListAsync();
        }

        // GET: api/Elements/id/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Element>> GetElementById(int id)
        {
            var element = await _context.Element.FindAsync(id);

            if (element == null)
            {
                return NotFound();
            }

            return element;
        }

        // PUT: api/Elements/id/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElement(int id, Element element)
        {
            if (id != element.AtomicNumber)
            {
                return BadRequest();
            }
            _context.Entry(element).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementExists(id))
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

        // POST: api/Elements/
        [HttpPost]
        public async Task<ActionResult<Element>> PostElement(Element element)
        {
            _context.Element.Add(element);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetElement", new { id = element.AtomicNumber }, element);
        }

        // DELETE: api/Elements/id/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Element>> DeleteElement(int id)
        {
            var element = await _context.Element.FindAsync(id);
            if (element == null)
            {
                return NotFound();
            }
            _context.Element.Remove(element);
            await _context.SaveChangesAsync();
            return element;
        }

        private bool ElementExists(int id)
        {
            return _context.Element.Any(e => e.AtomicNumber == id);
        }
    }
}

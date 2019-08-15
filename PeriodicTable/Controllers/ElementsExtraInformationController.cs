using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTable.Model;

namespace PeriodicTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsExtraInformationController : ControllerBase
    {
        private readonly PeriodicTableContext _context;

        public ElementsExtraInformationController(PeriodicTableContext context)
        {
            _context = context;
        }

        // GET: api/ElementsExtraInformation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElementsExtraInformation>>> GetElementsExtraInformation()
        {
            return await _context.ElementsExtraInformation.ToListAsync();
        }

        // GET: api/ElementsExtraInformation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElementsExtraInformation>> GetElementsExtraInformation(int id)
        {
            var elementsExtraInformation = await _context.ElementsExtraInformation.FindAsync(id);

            if (elementsExtraInformation == null)
            {
                return NotFound();
            }

            return elementsExtraInformation;
        }

        // PUT: api/ElementsExtraInformation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElementsExtraInformation(int id, ElementsExtraInformation elementsExtraInformation)
        {
            if (id != elementsExtraInformation.AtomicNumber)
            {
                return BadRequest();
            }

            _context.Entry(elementsExtraInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementsExtraInformationExists(id))
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

        // POST: api/ElementsExtraInformation
        [HttpPost]
        public async Task<ActionResult<ElementsExtraInformation>> PostElementsExtraInformation(ElementsExtraInformation elementsExtraInformation)
        {
            _context.ElementsExtraInformation.Add(elementsExtraInformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ElementsExtraInformationExists(elementsExtraInformation.AtomicNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetElementsExtraInformation", new { id = elementsExtraInformation.AtomicNumber }, elementsExtraInformation);
        }

        // DELETE: api/ElementsExtraInformation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElementsExtraInformation>> DeleteElementsExtraInformation(int id)
        {
            var elementsExtraInformation = await _context.ElementsExtraInformation.FindAsync(id);
            if (elementsExtraInformation == null)
            {
                return NotFound();
            }

            _context.ElementsExtraInformation.Remove(elementsExtraInformation);
            await _context.SaveChangesAsync();

            return elementsExtraInformation;
        }

        private bool ElementsExtraInformationExists(int id)
        {
            return _context.ElementsExtraInformation.Any(e => e.AtomicNumber == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeriodicTable.Model;
using PeriodicTable.Models;

namespace PeriodicTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementsBasicInformationsController : ControllerBase
    {
        private readonly PeriodicTableContext _context;

        public ElementsBasicInformationsController(PeriodicTableContext context)
        {
            _context = context;
        }

        // GET: api/ElementsBasicInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElementsBasicInformation>>> GetElementsBasicInformation()
        {
            return await _context.ElementsBasicInformation.ToListAsync();
        }

        // GET: api/ElementsBasicInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ElementsBasicInformation>> GetElementsBasicInformation(int id)
        {
            var elementsBasicInformation = await _context.ElementsBasicInformation.FindAsync(id);

            if (elementsBasicInformation == null)
            {
                return NotFound();
            }

            return elementsBasicInformation;
        }

        // PUT: api/ElementsBasicInformations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElementsBasicInformation(int id, ElementsBasicInformation elementsBasicInformation)
        {
            if (id != elementsBasicInformation.AtomicNumber)
            {
                return BadRequest();
            }

            _context.Entry(elementsBasicInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElementsBasicInformationExists(id))
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

        // POST: api/ElementsBasicInformations
        [HttpPost]
        public async Task<ActionResult<ElementsBasicInformation>> PostElementsBasicInformation(ElementsBasicInformation elementsBasicInformation)
        {
            _context.ElementsBasicInformation.Add(elementsBasicInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElementsBasicInformation", new { id = elementsBasicInformation.AtomicNumber }, elementsBasicInformation);
        }

        // DELETE: api/ElementsBasicInformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ElementsBasicInformation>> DeleteElementsBasicInformation(int id)
        {
            var elementsBasicInformation = await _context.ElementsBasicInformation.FindAsync(id);
            if (elementsBasicInformation == null)
            {
                return NotFound();
            }

            _context.ElementsBasicInformation.Remove(elementsBasicInformation);
            await _context.SaveChangesAsync();

            return elementsBasicInformation;
        }

        private bool ElementsBasicInformationExists(int id)
        {
            return _context.ElementsBasicInformation.Any(e => e.AtomicNumber == id);
        }
    }
}

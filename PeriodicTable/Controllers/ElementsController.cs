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
        [HttpGet("id/{id}")]
        public async Task<ActionResult<Element>> GetElementById(int id)
        {
            var element = await _context.Element.FindAsync(id);

            if (element == null)
            {
                return NotFound();
            }

            return element;
        }

        // GET: api/Elements/search/name/Hydro
        [HttpGet("search/name/{query}")]
        public async Task<List<Element>> SearchElementByName(string query)
        {
            var element = from m in _context.Element
                        select m; 

            if (!String.IsNullOrEmpty(query))
            {
                // Search keywords on name.
                element = element.Where(s => s.Name.ToLower().Contains(query.ToLower())); 
            }

            var returned = await element.ToListAsync(); //return the result.

            return returned;
        }

        // GET: api/Elements/search/symbol/H
        [HttpGet("search/symbol/{query}")]
        public async Task<List<Element>> SearchElementBySymbol(string query)
        {
            var element = from m in _context.Element
                          select m;

            if (!String.IsNullOrEmpty(query))
            {
                // Search keywords on name.
                element = element.Where(s => s.Symbol.ToLower().Contains(query.ToLower()));
            }

            var returned = await element.ToListAsync(); //return the result.

            return returned;
        }

        // GET: api/Elements/search/group/Noble
        [HttpGet("search/group/{query}")]
        public async Task<List<Element>> SearchElementByGroup(string query)
        {
            var element = from m in _context.Element
                          select m;

            if (!String.IsNullOrEmpty(query))
            {
                // Search keywords on name.
                element = element.Where(s => s.GroupBlock.ToLower().Contains(query.ToLower()));
            }

            var returned = await element.ToListAsync(); //return the result.

            return returned;
        }

        private bool ElementExists(int id)
        {
            return _context.Element.Any(e => e.AtomicNumber == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeriodicElements.Models;

namespace PeriodicElements.Models
{
    public class PeriodicElementsContext : DbContext
    {
        public PeriodicElementsContext (DbContextOptions<PeriodicElementsContext> options)
            : base(options)
        {
        }

        public DbSet<PeriodicElements.Models.Element> Element { get; set; }
    }
}

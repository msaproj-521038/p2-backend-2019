using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PeriodicTable.Models
{
    public class PeriodicTableContext : DbContext
    {
        public PeriodicTableContext (DbContextOptions<PeriodicTableContext> options)
            : base(options)
        {
        }

        public DbSet<PeriodicTable.Models.Element> Element { get; set; }
    }
}

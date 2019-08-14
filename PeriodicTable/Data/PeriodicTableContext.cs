using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeriodicTable.Model;

namespace PeriodicTable.Models
{
    public class PeriodicTableContext : DbContext
    {
        public PeriodicTableContext (DbContextOptions<PeriodicTableContext> options)
            : base(options)
        {
        }

        public DbSet<PeriodicTable.Model.Element> Element { get; set; }
    }
}

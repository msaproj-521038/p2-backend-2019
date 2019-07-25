using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MobileInfoAPI.Models
{
    public class MobileInfoAPIContext : DbContext
    {
        public MobileInfoAPIContext (DbContextOptions<MobileInfoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MobileInfoAPI.Models.MobileSpecs> MobileSpecs { get; set; }
    }
}

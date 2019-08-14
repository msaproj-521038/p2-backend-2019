using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PeriodicTable.Model
{
    public partial class PeriodicTableContext : DbContext
    {
        public PeriodicTableContext()
        {
        }

        public PeriodicTableContext(DbContextOptions<PeriodicTableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Element> Element { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:msa-p2-periodic-table.database.windows.net,1433;Initial Catalog=PeriodicTable;Persist Security Info=False;User ID=raiton-1;Password=suiton-2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Element>(entity =>
            {
                entity.Property(e => e.AtomicNumber).ValueGeneratedNever();
            });
        }
    }
}

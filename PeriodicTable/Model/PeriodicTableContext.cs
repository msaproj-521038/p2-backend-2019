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

        public virtual DbSet<ElementsBasicInformation> ElementsBasicInformation { get; set; }
        public virtual DbSet<ElementsExtraInformation> ElementsExtraInformation { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

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

            modelBuilder.Entity<ElementsBasicInformation>(entity =>
            {
                entity.HasKey(e => e.AtomicNumber)
                    .HasName("PK_BASIC");

                entity.Property(e => e.AtomicNumber).ValueGeneratedNever();
            });

            modelBuilder.Entity<ElementsExtraInformation>(entity =>
            {
                entity.HasKey(e => e.AtomicNumber)
                    .HasName("PK_EXTRA");

                entity.Property(e => e.AtomicNumber).ValueGeneratedNever();

                entity.HasOne(d => d.AtomicNumberNavigation)
                    .WithOne(p => p.ElementsExtraInformation)
                    .HasForeignKey<ElementsExtraInformation>(d => d.AtomicNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ElementsE__Atomi__628FA481");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserInfo__206D919091B7B658");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.AtomicNumber1Navigation)
                    .WithMany(p => p.UserInfoAtomicNumber1Navigation)
                    .HasForeignKey(d => d.AtomicNumber1)
                    .HasConstraintName("FK__UserInfo__Atomic__68487DD7");

                entity.HasOne(d => d.AtomicNumber2Navigation)
                    .WithMany(p => p.UserInfoAtomicNumber2Navigation)
                    .HasForeignKey(d => d.AtomicNumber2)
                    .HasConstraintName("FK__UserInfo__Atomic__693CA210");

                entity.HasOne(d => d.AtomicNumber3Navigation)
                    .WithMany(p => p.UserInfoAtomicNumber3Navigation)
                    .HasForeignKey(d => d.AtomicNumber3)
                    .HasConstraintName("FK__UserInfo__Atomic__6A30C649");
            });
        }
    }
}

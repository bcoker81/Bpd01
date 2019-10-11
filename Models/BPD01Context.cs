using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BPD01.Models {
    public partial class BPD01Context : DbContext {
        public BPD01Context () { }

        public BPD01Context (DbContextOptions<BPD01Context> options) : base (options) { }

        public virtual DbSet<Grants> Grants { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //                 optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=BPD01;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Grants> (entity => {
                entity.Property (e => e.Division)
                    .IsRequired ()
                    .HasMaxLength (15)
                    .IsUnicode (false);

                entity.Property (e => e.FinancialReportDueDate).HasColumnType ("datetime");

                entity.Property (e => e.GrantName)
                    .IsRequired ()
                    .HasMaxLength (30)
                    .IsUnicode (false);

                entity.Property (e => e.ProgrammingReportDueDate).HasColumnType ("datetime");

                entity.Property (e => e.ProjectEndDate).HasColumnType ("datetime");

                entity.Property (e => e.ProjectStartDate).HasColumnType ("datetime");

                entity.Property (e => e.Status)
                    .IsRequired ()
                    .HasMaxLength (15)
                    .IsUnicode (false);
            });

            OnModelCreatingPartial (modelBuilder);
        }

        partial void OnModelCreatingPartial (ModelBuilder modelBuilder);
    }
}
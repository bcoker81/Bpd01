using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BPD01.Models
{
    public partial class GRANTrakContext : DbContext
    {
        public GRANTrakContext()
        {
        }

        public GRANTrakContext(DbContextOptions<GRANTrakContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Expenditures> Expenditures { get; set; }
        public virtual DbSet<Extensions> Extensions { get; set; }
        public virtual DbSet<Gans> Gans { get; set; }
        public virtual DbSet<Grants> Grants { get; set; }
        public virtual DbSet<Ldpr> Ldpr { get; set; }
        public virtual DbSet<PickLists> PickLists { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }

        //         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //         {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        // #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                 optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=GRANTrak;Trusted_Connection=True;");
        //             }
        //         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.Property(e => e.AddBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileType).HasMaxLength(255);

                entity.Property(e => e.FkId).HasColumnName("FK_Id");

                entity.Property(e => e.FkTable)
                    .HasColumnName("FK_Table")
                    .HasMaxLength(20);

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.Uri).HasMaxLength(255);
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.HasIndex(e => e.FkGrantId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.Allocation).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Expenses).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkGrantId).HasColumnName("FK_Grant_Id");

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.Remaining).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReportingCategory).HasMaxLength(10);

                entity.HasOne(d => d.FkGrant)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.FkGrantId);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.HasIndex(e => e.FkGrantId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.FkGrantId).HasColumnName("FK_Grant_Id");

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.HasOne(d => d.FkGrant)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.FkGrantId);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.HasIndex(e => e.FkAttachmentId);

                entity.Property(e => e.FkAttachmentId).HasColumnName("FK_Attachment_Id");

                entity.HasOne(d => d.FkAttachment)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.FkAttachmentId);
            });

            modelBuilder.Entity<Expenditures>(entity =>
            {
                entity.HasKey(e => e.ExpenditureId);

                entity.HasIndex(e => e.FkCategoryId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BpdAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BpdNotes).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.FkCategoryId).HasColumnName("FK_Category_Id");

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.SamDocNumber).HasMaxLength(100);

                entity.Property(e => e.Vendor).HasMaxLength(50);

                entity.HasOne(d => d.FkCategory)
                    .WithMany(p => p.Expenditures)
                    .HasForeignKey(d => d.FkCategoryId);
            });

            modelBuilder.Entity<Extensions>(entity =>
            {
                entity.HasKey(e => e.GrantExtensionId);

                entity.HasIndex(e => e.FkGrantId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.FkGrantId).HasColumnName("FK_Grant_Id");

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.HasOne(d => d.FkGrant)
                    .WithMany(p => p.Extensions)
                    .HasForeignKey(d => d.FkGrantId);
            });

            modelBuilder.Entity<Gans>(entity =>
            {
                entity.HasKey(e => e.Ganid);

                entity.ToTable("GANs");

                entity.HasIndex(e => e.FkGrantId);

                entity.Property(e => e.Ganid).HasColumnName("GANId");

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.FkGrantId).HasColumnName("FK_Grant_Id");

                entity.Property(e => e.GanNotes)
                    .HasColumnName("GAN_Notes")
                    .HasMaxLength(500);

                entity.Property(e => e.Ganstatus).HasColumnName("GANStatus");

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.SubmissionInitials).HasMaxLength(10);

                entity.HasOne(d => d.FkGrant)
                    .WithMany(p => p.Gans)
                    .HasForeignKey(d => d.FkGrantId);
            });

            modelBuilder.Entity<Grants>(entity =>
            {
                entity.Property(e => e.Accountant).HasMaxLength(127);

                entity.Property(e => e.Adjustments).HasMaxLength(35);

                entity.Property(e => e.AwardAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AwardContractNumber).HasMaxLength(255);

                entity.Property(e => e.CfdaNumber).HasMaxLength(32);

                entity.Property(e => e.Component).HasMaxLength(10);

                entity.Property(e => e.CreateBy).HasMaxLength(100);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.Expenditures).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrantName).HasMaxLength(255);

                entity.Property(e => e.Match).HasMaxLength(32);

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.MshpGrantNumber).HasMaxLength(10);

                entity.Property(e => e.NickName).HasMaxLength(32);

                entity.Property(e => e.ProjectDirector).HasMaxLength(255);

                entity.Property(e => e.RemainingBal).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Ldpr>(entity =>
            {
                entity.HasIndex(e => e.FkGrantId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.FkGrantId).HasColumnName("FK_Grant_Id");

                entity.Property(e => e.LdprNumber).HasMaxLength(10);

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.HasOne(d => d.FkGrant)
                    .WithMany(p => p.Ldpr)
                    .HasForeignKey(d => d.FkGrantId);
            });

            modelBuilder.Entity<PickLists>(entity =>
            {
                entity.HasKey(e => e.PickListId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.PickList).HasMaxLength(32);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.HasIndex(e => e.FkGrantId);

                entity.Property(e => e.AddBy).HasMaxLength(100);

                entity.Property(e => e.FkGrantId).HasColumnName("FK_Grant_Id");

                entity.Property(e => e.ModBy).HasMaxLength(100);

                entity.Property(e => e.ReportType).HasMaxLength(1);

                entity.HasOne(d => d.FkGrant)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.FkGrantId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

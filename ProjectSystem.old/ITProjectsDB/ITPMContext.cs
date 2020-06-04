using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITPM.Database
{
    public partial class ITPMContext : DbContext
    {
        public ITPMContext()
        {
        }

        public ITPMContext(DbContextOptions<ITPMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Purpose> Purpose { get; set; }
        public virtual DbSet<Scope> Scope { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ITPM;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectKey)
                    .HasName("PK_Projects");

                entity.HasIndex(e => e.ProjectName)
                    .HasName("IX_Projects")
                    .IsUnique();

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.StageKeyNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.StageKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Stage");

                entity.HasOne(d => d.StatusKeyNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.StatusKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Status");
            });

            modelBuilder.Entity<Purpose>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.PurposeKey });

                entity.Property(e => e.PurposeKey).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Purpose)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purpose_Projects");
            });

            modelBuilder.Entity<Scope>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.ScopeKey });

                entity.Property(e => e.ScopeKey).ValueGeneratedOnAdd();

                entity.Property(e => e.ScopeExclusions)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ScopeInclusions)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Scope)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Scope_Projects");
            });

            modelBuilder.Entity<Stage>(entity =>
            {
                entity.HasKey(e => e.StageKey);

                entity.Property(e => e.Stage1)
                    .IsRequired()
                    .HasColumnName("Stage")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusKey);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.TaskKey });

                entity.Property(e => e.TaskKey).ValueGeneratedOnAdd();

                entity.Property(e => e.TaskCreateDate).HasColumnType("datetime");

                entity.Property(e => e.TaskTargetDueDate).HasColumnType("datetime");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tasks_Projects");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

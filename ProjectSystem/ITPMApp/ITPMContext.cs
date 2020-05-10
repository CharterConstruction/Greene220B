using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITPMApp
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

        public virtual DbSet<Alignment> Alignment { get; set; }
        public virtual DbSet<Dependencies> Dependencies { get; set; }
        public virtual DbSet<GoalObjectives> GoalObjectives { get; set; }
        public virtual DbSet<GoalObjectivesView> GoalObjectivesView { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<ObjProjectsDependenciesTestview> ObjProjectsDependenciesTestview { get; set; }
        public virtual DbSet<Objectives> Objectives { get; set; }
        public virtual DbSet<ProblemSystems> ProblemSystems { get; set; }
        public virtual DbSet<Problems> Problems { get; set; }
        public virtual DbSet<ProjectBlockers> ProjectBlockers { get; set; }
        public virtual DbSet<ProjectDependencies> ProjectDependencies { get; set; }
        public virtual DbSet<ProjectGoals> ProjectGoals { get; set; }
        public virtual DbSet<ProjectNotes> ProjectNotes { get; set; }
        public virtual DbSet<ProjectObjectives> ProjectObjectives { get; set; }
        public virtual DbSet<ProjectPurposeView> ProjectPurposeView { get; set; }
        public virtual DbSet<ProjectScopeView> ProjectScopeView { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Purpose> Purpose { get; set; }
        public virtual DbSet<Scope> Scope { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SystemCategories> SystemCategories { get; set; }
        public virtual DbSet<Systems> Systems { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<VProjectsByObjective> VProjectsByObjective { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=ITPM;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alignment>(entity =>
            {
                entity.HasKey(e => e.AlignmentKey);

                entity.Property(e => e.AlignmentKey).HasColumnName("Alignment_Key");

                entity.Property(e => e.AlignmentTitle)
                    .IsRequired()
                    .HasColumnName("Alignment_Title")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dependencies>(entity =>
            {
                entity.HasKey(e => e.DependencyKey);

                entity.Property(e => e.DependencyKey).HasColumnName("Dependency_Key");

                entity.Property(e => e.DependencyCant)
                    .HasColumnName("Dependency_Cant")
                    .HasMaxLength(10);

                entity.Property(e => e.DependencyCode)
                    .IsRequired()
                    .HasColumnName("Dependency_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.DependencyDescription).HasColumnName("Dependency_Description");

                entity.Property(e => e.DependencyIcon).HasColumnName("Dependency_Icon");

                entity.Property(e => e.DependencyTitle)
                    .IsRequired()
                    .HasColumnName("Dependency_Title")
                    .HasMaxLength(50);

                entity.Property(e => e.DependencyUntil)
                    .HasColumnName("Dependency_Until")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<GoalObjectives>(entity =>
            {
                entity.HasKey(e => new { e.GoalKey, e.ObjectiveKey, e.AlignmentKey });

                entity.ToTable("Goal_Objectives");

                entity.HasIndex(e => new { e.GoalKey, e.ObjectiveKey, e.AlignmentKey })
                    .HasName("IX_Goal_Objectives")
                    .IsUnique();

                entity.Property(e => e.GoalKey).HasColumnName("Goal_Key");

                entity.Property(e => e.ObjectiveKey).HasColumnName("Objective_Key");

                entity.Property(e => e.AlignmentKey).HasColumnName("Alignment_Key");

                entity.Property(e => e.GoalAlignmentReason).HasColumnName("Goal_Alignment_Reason");

                entity.HasOne(d => d.AlignmentKeyNavigation)
                    .WithMany(p => p.GoalObjectives)
                    .HasForeignKey(d => d.AlignmentKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_Objectives_Alignment");

                entity.HasOne(d => d.GoalKeyNavigation)
                    .WithMany(p => p.GoalObjectives)
                    .HasForeignKey(d => d.GoalKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_Objectives_Goals");

                entity.HasOne(d => d.ObjectiveKeyNavigation)
                    .WithMany(p => p.GoalObjectives)
                    .HasForeignKey(d => d.ObjectiveKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goal_Objectives_Objectives");
            });

            modelBuilder.Entity<GoalObjectivesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Goal_Objectives_View");

                entity.Property(e => e.AlignmentKey).HasColumnName("Alignment_Key");

                entity.Property(e => e.AlignmentTitle)
                    .IsRequired()
                    .HasColumnName("Alignment_Title")
                    .HasMaxLength(50);

                entity.Property(e => e.GoalDescription).HasColumnName("Goal_Description");

                entity.Property(e => e.GoalKey).HasColumnName("Goal_Key");

                entity.Property(e => e.GoalName)
                    .HasColumnName("Goal_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.GoalOwner)
                    .HasColumnName("Goal_Owner")
                    .HasMaxLength(50);

                entity.Property(e => e.GoalPriority).HasColumnName("Goal_Priority");

                entity.Property(e => e.ObjectiveDetails).HasColumnName("Objective_Details");

                entity.Property(e => e.ObjectiveKey).HasColumnName("Objective_Key");

                entity.Property(e => e.ObjectiveTitle)
                    .IsRequired()
                    .HasColumnName("Objective_Title")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StatusDescription).HasColumnName("Status_Description");
            });

            modelBuilder.Entity<Goals>(entity =>
            {
                entity.HasKey(e => e.GoalKey);

                entity.Property(e => e.GoalKey).HasColumnName("Goal_Key");

                entity.Property(e => e.GoalDescription).HasColumnName("Goal_Description");

                entity.Property(e => e.GoalName)
                    .HasColumnName("Goal_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.GoalOwner)
                    .HasColumnName("Goal_Owner")
                    .HasMaxLength(50);

                entity.Property(e => e.GoalPriority).HasColumnName("Goal_Priority");
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.NoteKey });

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.NoteKey).HasColumnName("Note_Key");

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.NoteDate)
                    .HasColumnName("Note_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notes_Projects");
            });

            modelBuilder.Entity<ObjProjectsDependenciesTestview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ObjProjectsDependencies_TESTVIEW");

                entity.Property(e => e.ChildProjectKey).HasColumnName("Child_Project_Key");

                entity.Property(e => e.ChildProjectName)
                    .HasColumnName("Child_Project_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.DependencyCode)
                    .HasColumnName("Dependency_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.DependencyDescription).HasColumnName("Dependency_Description");

                entity.Property(e => e.ObjectiveKey).HasColumnName("Objective_Key");

                entity.Property(e => e.ParentProjectKey).HasColumnName("Parent_Project_Key");

                entity.Property(e => e.ParentProjectName)
                    .HasColumnName("Parent_Project_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Objectives>(entity =>
            {
                entity.HasKey(e => e.ObjectiveKey);

                entity.Property(e => e.ObjectiveKey).HasColumnName("Objective_Key");

                entity.Property(e => e.ObjectiveDetails).HasColumnName("Objective_Details");

                entity.Property(e => e.ObjectiveTitle)
                    .IsRequired()
                    .HasColumnName("Objective_Title")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusKey).HasColumnName("Status_Key");

                entity.HasOne(d => d.StatusKeyNavigation)
                    .WithMany(p => p.Objectives)
                    .HasForeignKey(d => d.StatusKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Objectives_Status");
            });

            modelBuilder.Entity<ProblemSystems>(entity =>
            {
                entity.HasKey(e => new { e.ProblemKey, e.SystemKey });

                entity.ToTable("Problem_Systems");

                entity.Property(e => e.ProblemKey).HasColumnName("Problem_Key");

                entity.Property(e => e.SystemKey).HasColumnName("System_Key");

                entity.HasOne(d => d.ProblemKeyNavigation)
                    .WithMany(p => p.ProblemSystems)
                    .HasForeignKey(d => d.ProblemKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Problem_Systems_Problems1");

                entity.HasOne(d => d.SystemKeyNavigation)
                    .WithMany(p => p.ProblemSystems)
                    .HasForeignKey(d => d.SystemKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Problem_Systems_Systems");
            });

            modelBuilder.Entity<Problems>(entity =>
            {
                entity.HasKey(e => e.ProblemKey)
                    .HasName("PK_Problems_1");

                entity.Property(e => e.ProblemKey).HasColumnName("Problem_Key");

                entity.Property(e => e.ProblemDescription).HasColumnName("Problem_Description");

                entity.Property(e => e.ProblemEffects).HasColumnName("Problem_Effects");

                entity.Property(e => e.ProblemName)
                    .HasColumnName("Problem_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProblemReason).HasColumnName("Problem_Reason");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Problems)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Problems_Projects1");
            });

            modelBuilder.Entity<ProjectBlockers>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.ProjectBlockerKey });

                entity.ToTable("Project_Blockers");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.ProjectBlockerKey).HasColumnName("Project_BlockerKey");

                entity.HasOne(d => d.ProjectBlockerKeyNavigation)
                    .WithMany(p => p.ProjectBlockersProjectBlockerKeyNavigation)
                    .HasForeignKey(d => d.ProjectBlockerKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Blockers_Projects1");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.ProjectBlockersProjectKeyNavigation)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Blockers_Projects");
            });

            modelBuilder.Entity<ProjectDependencies>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.RelatedProjectKey });

                entity.ToTable("Project_Dependencies");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.RelatedProjectKey).HasColumnName("Related_ProjectKey");

                entity.Property(e => e.DependencyKey).HasColumnName("Dependency_Key");

                entity.Property(e => e.DependencyReason).HasColumnName("Dependency_Reason");

                entity.HasOne(d => d.DependencyKeyNavigation)
                    .WithMany(p => p.ProjectDependencies)
                    .HasForeignKey(d => d.DependencyKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Dependencies_Dependencies");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.ProjectDependenciesProjectKeyNavigation)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Dependencies_Projects");

                entity.HasOne(d => d.RelatedProjectKeyNavigation)
                    .WithMany(p => p.ProjectDependenciesRelatedProjectKeyNavigation)
                    .HasForeignKey(d => d.RelatedProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Dependencies_Projects1");
            });

            modelBuilder.Entity<ProjectGoals>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.GoalKey });

                entity.ToTable("Project_Goals");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.GoalKey).HasColumnName("Goal_Key");

                entity.HasOne(d => d.GoalKeyNavigation)
                    .WithMany(p => p.ProjectGoals)
                    .HasForeignKey(d => d.GoalKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Goals_Goals");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.ProjectGoals)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Goals_Projects");
            });

            modelBuilder.Entity<ProjectNotes>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.NoteKey });

                entity.ToTable("Project_Notes");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.NoteKey).HasColumnName("Note_Key");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.ProjectNotes)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Notes_Projects");
            });

            modelBuilder.Entity<ProjectObjectives>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.ObjectiveKey });

                entity.ToTable("Project_Objectives");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.ObjectiveKey).HasColumnName("Objective_Key");

                entity.Property(e => e.ProjectOrder)
                    .HasColumnName("Project_Order")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.ObjectiveKeyNavigation)
                    .WithMany(p => p.ProjectObjectives)
                    .HasForeignKey(d => d.ObjectiveKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Objectives_Objectives");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.ProjectObjectives)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Objectives_Projects");
            });

            modelBuilder.Entity<ProjectPurposeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Project_Purpose_View");

                entity.Property(e => e.Benefits).IsRequired();

                entity.Property(e => e.CombinedPurpose).HasColumnName("Combined Purpose");

                entity.Property(e => e.ProjectConcept).HasColumnName("Project_Concept");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.WhatIfWeDont).IsRequired();

                entity.Property(e => e.WhyNotWait).IsRequired();

                entity.Property(e => e.WhyNow).IsRequired();
            });

            modelBuilder.Entity<ProjectScopeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Project_Scope_View");

                entity.Property(e => e.ProjectConcept).HasColumnName("Project_Concept");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ScopeExclusions)
                    .IsRequired()
                    .HasColumnName("Scope Exclusions")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ScopeInclusions)
                    .IsRequired()
                    .HasColumnName("Scope Inclusions")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ScopeSummary)
                    .HasColumnName("Scope Summary")
                    .HasMaxLength(56);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectKey);

                entity.HasIndex(e => e.ProjectName)
                    .HasName("IX_Projects")
                    .IsUnique();

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.ProjectConcept).HasColumnName("Project_Concept");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("Project_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.StageKey).HasColumnName("Stage_Key");

                entity.Property(e => e.StatusKey).HasColumnName("Status_Key");

                entity.HasOne(d => d.StageKeyNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.StageKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Stage");

                entity.HasOne(d => d.StatusKeyNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.StatusKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Status");
            });

            modelBuilder.Entity<Purpose>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.PurposeKey });

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.PurposeKey)
                    .HasColumnName("Purpose_Key")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Purpose)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purpose_Projects");
            });

            modelBuilder.Entity<Scope>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.ScopeKey });

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.ScopeKey)
                    .HasColumnName("Scope_Key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ScopeExclusions)
                    .HasColumnName("Scope_Exclusions")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ScopeInclusions)
                    .HasColumnName("Scope_Inclusions")
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

                entity.Property(e => e.StageKey).HasColumnName("Stage_Key");

                entity.Property(e => e.Stage1)
                    .IsRequired()
                    .HasColumnName("Stage")
                    .HasMaxLength(25);

                entity.Property(e => e.StageDescription).HasColumnName("Stage_Description");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusKey);

                entity.Property(e => e.StatusKey).HasColumnName("Status_Key");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasColumnName("Status")
                    .HasMaxLength(25);

                entity.Property(e => e.StatusDescription).HasColumnName("Status_Description");
            });

            modelBuilder.Entity<SystemCategories>(entity =>
            {
                entity.HasKey(e => e.SystemCategoryKey);

                entity.ToTable("System_Categories");

                entity.Property(e => e.SystemCategoryKey).HasColumnName("System_Category_Key");

                entity.Property(e => e.SystemCategoryDescription).HasColumnName("System_Category_Description");

                entity.Property(e => e.SystemCategoryName)
                    .IsRequired()
                    .HasColumnName("System_Category_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Systems>(entity =>
            {
                entity.HasKey(e => e.SystemKey);

                entity.Property(e => e.SystemKey).HasColumnName("System_Key");

                entity.Property(e => e.SystemCategoryKey).HasColumnName("System_Category_Key");

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasColumnName("System_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SystemPurpose).HasColumnName("System_Purpose");

                entity.HasOne(d => d.SystemCategoryKeyNavigation)
                    .WithMany(p => p.Systems)
                    .HasForeignKey(d => d.SystemCategoryKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Systems_System_Categories");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.HasKey(e => new { e.ProjectKey, e.TaskKey });

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.TaskKey)
                    .HasColumnName("Task_Key")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TaskCreateDate)
                    .HasColumnName("Task_CreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskEstimatedEffortHours).HasColumnName("Task_EstimatedEffortHours");

                entity.Property(e => e.TaskOrder).HasColumnName("Task_Order");

                entity.Property(e => e.TaskSummary).HasColumnName("Task_Summary");

                entity.Property(e => e.TaskTargetDueDate)
                    .HasColumnName("Task_TargetDueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasColumnName("Task_Title")
                    .HasMaxLength(25);

                entity.Property(e => e.TaskWorstCaseEffortHours).HasColumnName("Task_WorstCaseEffortHours");

                entity.HasOne(d => d.ProjectKeyNavigation)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tasks_Projects");
            });

            modelBuilder.Entity<VProjectsByObjective>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProjects_ByObjective");

                entity.Property(e => e.BlockerProjectKey).HasColumnName("Blocker_Project_Key");

                entity.Property(e => e.DependencyCode)
                    .HasColumnName("Dependency_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.DependencyDescription).HasColumnName("Dependency_Description");

                entity.Property(e => e.DependencyIcon).HasColumnName("Dependency_Icon");

                entity.Property(e => e.DependencyReason).HasColumnName("Dependency_Reason");

                entity.Property(e => e.DependencyTitle)
                    .HasColumnName("Dependency_Title")
                    .HasMaxLength(50);

                entity.Property(e => e.IsBlocked).HasColumnName("Is_Blocked");

                entity.Property(e => e.ObjectiveDetails).HasColumnName("objective_details");

                entity.Property(e => e.ObjectiveKey).HasColumnName("objective_key");

                entity.Property(e => e.ObjectiveTitle)
                    .HasColumnName("objective_title")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectConcept).HasColumnName("project_concept");

                entity.Property(e => e.ProjectKey).HasColumnName("Project_Key");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasColumnName("project_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectOrder)
                    .HasColumnName("project_order")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RelatedProjectKey).HasColumnName("Related_ProjectKey");

                entity.Property(e => e.Stage)
                    .IsRequired()
                    .HasColumnName("stage")
                    .HasMaxLength(25);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

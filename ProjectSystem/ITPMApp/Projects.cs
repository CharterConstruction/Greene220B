using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Projects
    {
        public Projects()
        {
            Notes = new HashSet<Notes>();
            Problems = new HashSet<Problems>();
            ProjectBlockersProjectBlockerKeyNavigation = new HashSet<ProjectBlockers>();
            ProjectBlockersProjectKeyNavigation = new HashSet<ProjectBlockers>();
            ProjectDependenciesProjectKeyNavigation = new HashSet<ProjectDependencies>();
            ProjectDependenciesRelatedProjectKeyNavigation = new HashSet<ProjectDependencies>();
            ProjectGoals = new HashSet<ProjectGoals>();
            ProjectNotes = new HashSet<ProjectNotes>();
            ProjectObjectives = new HashSet<ProjectObjectives>();
            Purpose = new HashSet<Purpose>();
            Scope = new HashSet<Scope>();
            Tasks = new HashSet<Tasks>();
        }

        public int ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public string ProjectConcept { get; set; }
        public int StageKey { get; set; }
        public int StatusKey { get; set; }

        public virtual Stage StageKeyNavigation { get; set; }
        public virtual Status StatusKeyNavigation { get; set; }
        public virtual ICollection<Notes> Notes { get; set; }
        public virtual ICollection<Problems> Problems { get; set; }
        public virtual ICollection<ProjectBlockers> ProjectBlockersProjectBlockerKeyNavigation { get; set; }
        public virtual ICollection<ProjectBlockers> ProjectBlockersProjectKeyNavigation { get; set; }
        public virtual ICollection<ProjectDependencies> ProjectDependenciesProjectKeyNavigation { get; set; }
        public virtual ICollection<ProjectDependencies> ProjectDependenciesRelatedProjectKeyNavigation { get; set; }
        public virtual ICollection<ProjectGoals> ProjectGoals { get; set; }
        public virtual ICollection<ProjectNotes> ProjectNotes { get; set; }
        public virtual ICollection<ProjectObjectives> ProjectObjectives { get; set; }
        public virtual ICollection<Purpose> Purpose { get; set; }
        public virtual ICollection<Scope> Scope { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Objectives
    {
        public Objectives()
        {
            GoalObjectives = new HashSet<GoalObjectives>();
            ProjectObjectives = new HashSet<ProjectObjectives>();
        }

        public int ObjectiveKey { get; set; }
        public string ObjectiveTitle { get; set; }
        public string ObjectiveDetails { get; set; }
        public int StatusKey { get; set; }

        public virtual Status StatusKeyNavigation { get; set; }
        public virtual ICollection<GoalObjectives> GoalObjectives { get; set; }
        public virtual ICollection<ProjectObjectives> ProjectObjectives { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Goals
    {
        public Goals()
        {
            GoalObjectives = new HashSet<GoalObjectives>();
            ProjectGoals = new HashSet<ProjectGoals>();
        }

        public int GoalKey { get; set; }
        public string GoalName { get; set; }
        public string GoalDescription { get; set; }
        public string GoalOwner { get; set; }
        public int? GoalPriority { get; set; }

        public virtual ICollection<GoalObjectives> GoalObjectives { get; set; }
        public virtual ICollection<ProjectGoals> ProjectGoals { get; set; }
    }
}

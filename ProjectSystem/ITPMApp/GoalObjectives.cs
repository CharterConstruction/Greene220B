using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class GoalObjectives
    {
        public int GoalKey { get; set; }
        public int ObjectiveKey { get; set; }
        public int AlignmentKey { get; set; }
        public string GoalAlignmentReason { get; set; }

        public virtual Alignment AlignmentKeyNavigation { get; set; }
        public virtual Goals GoalKeyNavigation { get; set; }
        public virtual Objectives ObjectiveKeyNavigation { get; set; }
    }
}

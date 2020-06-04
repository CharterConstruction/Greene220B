using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class GoalObjectivesView
    {
        public int GoalKey { get; set; }
        public string GoalName { get; set; }
        public string GoalDescription { get; set; }
        public string GoalOwner { get; set; }
        public int? GoalPriority { get; set; }
        public int ObjectiveKey { get; set; }
        public string ObjectiveTitle { get; set; }
        public string ObjectiveDetails { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public int AlignmentKey { get; set; }
        public string AlignmentTitle { get; set; }
    }
}

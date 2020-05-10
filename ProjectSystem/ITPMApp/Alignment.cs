using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Alignment
    {
        public Alignment()
        {
            GoalObjectives = new HashSet<GoalObjectives>();
        }

        public int AlignmentKey { get; set; }
        public string AlignmentTitle { get; set; }

        public virtual ICollection<GoalObjectives> GoalObjectives { get; set; }
    }
}

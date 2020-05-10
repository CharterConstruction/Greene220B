using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectGoals
    {
        public int ProjectKey { get; set; }
        public int GoalKey { get; set; }

        public virtual Goals GoalKeyNavigation { get; set; }
        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}

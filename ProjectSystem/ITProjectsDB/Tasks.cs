using System;
using System.Collections.Generic;

namespace ITPM.Database
{
    public partial class Tasks
    {
        public int ProjectKey { get; set; }
        public int TaskKey { get; set; }
        public string TaskTitle { get; set; }
        public string TaskSummary { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime? TaskTargetDueDate { get; set; }
        public int? TaskEstimatedEffortHours { get; set; }
        public int? TaskWorstCaseEffortHours { get; set; }
        public int? TaskOrder { get; set; }

        public virtual Project ProjectKeyNavigation { get; set; }
    }
}

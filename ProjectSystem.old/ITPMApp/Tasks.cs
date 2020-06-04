using System;
using System.Collections.Generic;

namespace ITPMApp
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

        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}

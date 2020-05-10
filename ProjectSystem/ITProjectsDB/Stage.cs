using System;
using System.Collections.Generic;

namespace ITProjectsDB
{
    public partial class Stage
    {
        public Stage()
        {
            Project = new HashSet<Project>();
        }

        public int StageKey { get; set; }
        public string Stage1 { get; set; }
        public string StageDescription { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}

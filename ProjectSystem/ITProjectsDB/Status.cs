using System;
using System.Collections.Generic;

namespace ITProjectsDB
{
    public partial class Status
    {
        public Status()
        {
            Project = new HashSet<Project>();
        }

        public int StatusKey { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}

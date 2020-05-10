using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Status
    {
        public Status()
        {
            Objectives = new HashSet<Objectives>();
            Projects = new HashSet<Projects>();
        }

        public int StatusKey { get; set; }
        public string Status1 { get; set; }
        public string StatusDescription { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<Objectives> Objectives { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}

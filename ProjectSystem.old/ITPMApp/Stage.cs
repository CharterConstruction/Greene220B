using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Stage
    {
        public Stage()
        {
            Projects = new HashSet<Projects>();
        }

        public int StageKey { get; set; }
        public string Stage1 { get; set; }
        public string StageDescription { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}

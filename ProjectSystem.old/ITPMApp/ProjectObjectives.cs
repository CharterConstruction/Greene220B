using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectObjectives
    {
        public int ProjectKey { get; set; }
        public int ObjectiveKey { get; set; }
        public string ProjectOrder { get; set; }

        public virtual Objectives ObjectiveKeyNavigation { get; set; }
        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}

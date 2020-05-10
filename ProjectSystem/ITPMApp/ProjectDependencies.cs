using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectDependencies
    {
        public int ProjectKey { get; set; }
        public int RelatedProjectKey { get; set; }
        public int DependencyKey { get; set; }
        public string DependencyReason { get; set; }

        public virtual Dependencies DependencyKeyNavigation { get; set; }
        public virtual Projects ProjectKeyNavigation { get; set; }
        public virtual Projects RelatedProjectKeyNavigation { get; set; }
    }
}

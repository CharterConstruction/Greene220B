using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Dependencies
    {
        public Dependencies()
        {
            ProjectDependencies = new HashSet<ProjectDependencies>();
        }

        public int DependencyKey { get; set; }
        public string DependencyCode { get; set; }
        public string DependencyTitle { get; set; }
        public string DependencyDescription { get; set; }
        public string DependencyIcon { get; set; }
        public string DependencyCant { get; set; }
        public string DependencyUntil { get; set; }

        public virtual ICollection<ProjectDependencies> ProjectDependencies { get; set; }
    }
}

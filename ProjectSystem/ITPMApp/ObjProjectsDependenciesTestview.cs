using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ObjProjectsDependenciesTestview
    {
        public int ObjectiveKey { get; set; }
        public int ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public int? ParentProjectKey { get; set; }
        public string ParentProjectName { get; set; }
        public int? ChildProjectKey { get; set; }
        public string ChildProjectName { get; set; }
        public string DependencyCode { get; set; }
        public string DependencyDescription { get; set; }
    }
}

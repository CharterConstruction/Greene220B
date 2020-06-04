using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectScopeView
    {
        public string ProjectName { get; set; }
        public string ProjectConcept { get; set; }
        public bool? ScopeExists { get; set; }
        public string ScopeSummary { get; set; }
        public string ScopeInclusions { get; set; }
        public string ScopeExclusions { get; set; }
    }
}

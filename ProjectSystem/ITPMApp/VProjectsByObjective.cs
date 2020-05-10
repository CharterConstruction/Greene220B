using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class VProjectsByObjective
    {
        public int? ObjectiveKey { get; set; }
        public string ObjectiveTitle { get; set; }
        public string ObjectiveDetails { get; set; }
        public int ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public string ProjectConcept { get; set; }
        public string ProjectOrder { get; set; }
        public string Stage { get; set; }
        public string Status { get; set; }
        public int IsBlocked { get; set; }
        public int BlockerProjectKey { get; set; }
        public int? RelatedProjectKey { get; set; }
        public string DependencyCode { get; set; }
        public string DependencyTitle { get; set; }
        public string DependencyDescription { get; set; }
        public string DependencyReason { get; set; }
        public string DependencyIcon { get; set; }
    }
}

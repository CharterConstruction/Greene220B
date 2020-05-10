using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectPurposeView
    {
        public string ProjectName { get; set; }
        public string ProjectConcept { get; set; }
        public bool? PurposeExists { get; set; }
        public string CombinedPurpose { get; set; }
        public string WhyNow { get; set; }
        public string WhyNotWait { get; set; }
        public string WhatIfWeDont { get; set; }
        public string Benefits { get; set; }
    }
}

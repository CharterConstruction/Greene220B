using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Systems
    {
        public Systems()
        {
            ProblemSystems = new HashSet<ProblemSystems>();
        }

        public int SystemKey { get; set; }
        public string SystemName { get; set; }
        public string SystemPurpose { get; set; }
        public int SystemCategoryKey { get; set; }

        public virtual SystemCategories SystemCategoryKeyNavigation { get; set; }
        public virtual ICollection<ProblemSystems> ProblemSystems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Problems
    {
        public Problems()
        {
            ProblemSystems = new HashSet<ProblemSystems>();
        }

        public int ProjectKey { get; set; }
        public int ProblemKey { get; set; }
        public string ProblemName { get; set; }
        public string ProblemDescription { get; set; }
        public string ProblemReason { get; set; }
        public string ProblemEffects { get; set; }

        public virtual Projects ProjectKeyNavigation { get; set; }
        public virtual ICollection<ProblemSystems> ProblemSystems { get; set; }
    }
}

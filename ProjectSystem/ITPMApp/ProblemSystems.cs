using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProblemSystems
    {
        public int ProblemKey { get; set; }
        public int SystemKey { get; set; }

        public virtual Problems ProblemKeyNavigation { get; set; }
        public virtual Systems SystemKeyNavigation { get; set; }
    }
}

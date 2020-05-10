using System;
using System.Collections.Generic;

namespace ITProjectsDB
{
    public partial class Scope
    {
        public int ProjectKey { get; set; }
        public int ScopeKey { get; set; }
        public string ScopeInclusions { get; set; }
        public string ScopeExclusions { get; set; }

        public virtual Project ProjectKeyNavigation { get; set; }
    }
}

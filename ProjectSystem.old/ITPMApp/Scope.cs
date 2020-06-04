using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Scope
    {
        public int ProjectKey { get; set; }
        public int ScopeKey { get; set; }
        public string ScopeInclusions { get; set; }
        public string ScopeExclusions { get; set; }

        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}

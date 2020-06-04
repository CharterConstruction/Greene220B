using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class ProjectBlockers
    {
        public int ProjectKey { get; set; }
        public int ProjectBlockerKey { get; set; }

        public virtual Projects ProjectBlockerKeyNavigation { get; set; }
        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}

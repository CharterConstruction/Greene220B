using System;
using System.Collections.Generic;

namespace ITPMApp
{
    public partial class Purpose
    {
        public int ProjectKey { get; set; }
        public int PurposeKey { get; set; }
        public string WhyNow { get; set; }
        public string WhyNotWait { get; set; }
        public string WhatIfWeDont { get; set; }
        public string Benefits { get; set; }

        public virtual Projects ProjectKeyNavigation { get; set; }
    }
}

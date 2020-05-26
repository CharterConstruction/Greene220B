using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class CostCenter
    {
        public int CostCenterKey { get; set; }
        public int CompanyKey { get; set; }
        public string CostCenterCode { get; set; }
        public string CostCenterDescription { get; set; }
        public bool SmallJobs { get; set; }
    }
}

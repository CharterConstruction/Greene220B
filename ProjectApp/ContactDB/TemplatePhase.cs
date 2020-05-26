using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class TemplatePhase
    {
        public int TimecardTemplateKey { get; set; }
        public int CompanyKey { get; set; }
        public int JobKey { get; set; }
        public int CostCenterKey { get; set; }
        public int PayrollDepartmentKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int PhaseKey { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int DateKey { get; set; }
    }
}

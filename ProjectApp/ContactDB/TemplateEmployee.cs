using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class TemplateEmployee
    {
        public int TemplateEmployeeKey { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int CostCenterKey { get; set; }
        public int TemplateKey { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int DateKey { get; set; }
    }
}

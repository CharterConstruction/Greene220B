using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class Template
    {
        public int TemplateKey { get; set; }
        public string TimecardTemplateName { get; set; }
        public int CompanyKey { get; set; }
        public int CostCenterKey { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int DateKey { get; set; }
    }
}

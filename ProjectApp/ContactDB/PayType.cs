using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class PayType
    {
        public string PayrollDepartmentCode { get; set; }
        public int CompanyKey { get; set; }
        public int PayTypeGroup { get; set; }
        public string PayTypeGroupName { get; set; }
        public string Visibility { get; set; }
        public bool ApprovalRequired { get; set; }
        public string PayTypeDescription { get; set; }
    }
}

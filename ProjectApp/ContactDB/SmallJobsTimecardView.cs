using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class SmallJobsTimecardView
    {
        public int Id { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int JobKey { get; set; }
        public int? PhaseKey { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int DateKey { get; set; }
        public string EntryGroup { get; set; }
        public string RowLabel { get; set; }
    }
}

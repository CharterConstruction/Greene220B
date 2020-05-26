using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class TimecardTimeEntryView
    {
        public string EntryGroup { get; set; }
        public string RowLabel { get; set; }
        public int TimeEntryKey { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int PayrollDepartmentKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int? JobKey { get; set; }
        public int? PhaseKey { get; set; }
        public int? CostCenterKey { get; set; }
        public int WeekEndDateKey { get; set; }
        public int DateKey { get; set; }
        public int Hours { get; set; }
        public string QuickNote { get; set; }
        public int EnteredByEmployeeKey { get; set; }
        public DateTime EntryTime { get; set; }
        public int ModifiedByEmployeeKey { get; set; }
        public DateTime ModifyTime { get; set; }
        public bool Approved { get; set; }
        public int ApprovedByEmployeeKey { get; set; }
        public DateTime ApproveTime { get; set; }
        public bool Submitted { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int TimecardId { get; set; }
    }
}

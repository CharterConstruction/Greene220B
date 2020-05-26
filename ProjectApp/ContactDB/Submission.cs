using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class Submission
    {
        public int SubmissionKey { get; set; }
        public int DateKey { get; set; }
        public int TimeKey { get; set; }
        public string Upn { get; set; }
        public string Json { get; set; }
        public bool ValidJson { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int CostCenterKey { get; set; }
        public int RequestCount { get; set; }
        public string Details { get; set; }
        public string Error { get; set; }
        public string JsonData { get; set; }
        public int ExecutionTimeInMs { get; set; }
    }
}

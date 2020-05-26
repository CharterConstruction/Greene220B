using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class Employee
    {
        public int EmployeeKey { get; set; }
        public int CompanyKey { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeTitle { get; set; }
        public int CostCenterKey { get; set; }
        public string EmployeeTeam { get; set; }
        public string EmployeeAdUpn { get; set; }
        public string EmployeeWorkersCompCode { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsField { get; set; }
        public int TimecardAccess { get; set; }
    }
}

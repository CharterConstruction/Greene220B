using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class Job
    {
        public int JobKey { get; set; }
        public int CompanyKey { get; set; }
        public string JobNumber { get; set; }
        public string JobName { get; set; }
        public string JobNumberName { get; set; }
        public int CostCenterKey { get; set; }
        public string JobStatus { get; set; }
        public decimal ContractAmount { get; set; }
        public string ProjectManager { get; set; }
        public string Superintendent { get; set; }
        public string AddressZipFull { get; set; }
        public string AddressFull { get; set; }
        public bool IsCertified { get; set; }
        public int Level { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsMyJob { get; set; }
        public bool IsTimecardJob { get; set; }
        public bool IsTeamJob { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class VEmployeeJob
    {
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int JobKey { get; set; }
        public int? Level { get; set; }
        public bool? IsSupervisor { get; set; }
        public bool? IsMyJob { get; set; }
        public bool? IsTimecardJob { get; set; }
        public bool? IsTeamJob { get; set; }
    }
}

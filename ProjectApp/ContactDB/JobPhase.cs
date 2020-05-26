using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class JobPhase
    {
        public int PhaseKey { get; set; }
        public int CompanyKey { get; set; }
        public int JobKey { get; set; }
        public string PhaseDivision { get; set; }
        public string PhaseCode { get; set; }
        public string PhaseDescription { get; set; }
        public string PhaseDivCsiDescription { get; set; }
    }
}

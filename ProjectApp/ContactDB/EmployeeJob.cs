using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class EmployeeJob
    {
        public int Id { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int JobKey { get; set; }
        public int Level { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int DateKey { get; set; }
    }
}

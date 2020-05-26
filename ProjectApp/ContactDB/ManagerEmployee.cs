using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class ManagerEmployee
    {
        public int Id { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int ManagerKey { get; set; }
    }
}

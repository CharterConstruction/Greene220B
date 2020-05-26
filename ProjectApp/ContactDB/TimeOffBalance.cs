using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class TimeOffBalance
    {
        public int EmployeeKey { get; set; }
        public int CompanyKey { get; set; }
        public string CompanyCode { get; set; }
        public string EmployeeCode { get; set; }
        public decimal VacationBalance { get; set; }
        public decimal VacationYtd { get; set; }
        public decimal HolidayBalance { get; set; }
        public decimal HolidayYtd { get; set; }
        public decimal SickBalance { get; set; }
        public decimal SickYtd { get; set; }
    }
}

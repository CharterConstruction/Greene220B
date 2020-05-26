using System;
using System.Collections.Generic;

namespace devTimecardDB
{
    public partial class DateView
    {
        public int? DateKey { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? CurrentWeekEndDateKey { get; set; }
        public int? PreviousWeekEndDateKey { get; set; }
        public string LongDateLabel { get; set; }
        public string ShortDateLabel { get; set; }
        public bool? IsWeekEndDate { get; set; }
        public bool? IsToday { get; set; }
        public int? Day { get; set; }
        public string WeekDayName { get; set; }
        public int? Month { get; set; }
        public int? Weekday { get; set; }
        public bool? IsWeekend { get; set; }
        public bool? IsHoliday { get; set; }
        public string HolidayText { get; set; }
        public int? WeekOfMonth { get; set; }
        public int? WeekOfYear { get; set; }
        public int? Year { get; set; }
        public bool? IsCompanyHoliday { get; set; }
    }
}

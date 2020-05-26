using System;
using System.Collections.Generic;
using System.Text;

namespace TimecardAdminApp.DateViews
{
    public class DateView
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

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class DateViewMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.DateViews.DateView, TimecardAdminApp.DateViews.DateView>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.DateViews.DateView ToRepositoryModel(this TimecardAdminApp.DateViews.DateView applicationObject)
        {
            return mapper.Map<TimecardRepository.DateViews.DateView>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.DateViews.DateView ToUIModel(this TimecardRepository.DateViews.DateView repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.DateViews.DateView>(repositoryObject);
        }

    }
}

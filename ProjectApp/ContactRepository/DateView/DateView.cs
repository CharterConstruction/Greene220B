using System;
using System.Collections.Generic;
using System.Text;

namespace TimecardRepository.DateViews
{
    public  class DateView
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


    public static class DateViewMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.DateView, TimecardRepository.DateViews.DateView>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.DateView object to Database object devTimecardDB.DateView for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.DateView ToDbModel(this TimecardRepository.DateViews.DateView repositoryObject)
        {
            return mapper.Map<devTimecardDB.DateView>(repositoryObject);
        }


        /// <summary>
        /// Converts devTimecardDB.DateView object to TimecardRepository.Models.DateView object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.DateViews.DateView ToRepositoryModel(this devTimecardDB.DateView databaseObject)
        {
            return mapper.Map<TimecardRepository.DateViews.DateView>(databaseObject);
        }

    }
}

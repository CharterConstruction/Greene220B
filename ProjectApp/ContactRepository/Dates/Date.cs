using System;
using System.Collections.Generic;
using System.Text;

namespace TimecardRepository.Dates
{
    public class Date
    {
        public int DateKey { get; set; }
        public DateTime Date1 { get; set; }
        public byte Day { get; set; }
        public string DaySuffix { get; set; }
        public byte Weekday { get; set; }
        public string WeekDayName { get; set; }
        public bool IsWeekend { get; set; }
        public bool IsHoliday { get; set; }
        public string HolidayText { get; set; }
        public byte DowinMonth { get; set; }
        public short DayOfYear { get; set; }
        public byte WeekOfMonth { get; set; }
        public byte WeekOfYear { get; set; }
        public byte IsoweekOfYear { get; set; }
        public byte Month { get; set; }
        public string MonthName { get; set; }
        public byte Quarter { get; set; }
        public string QuarterName { get; set; }
        public int Year { get; set; }
        public string Mmyyyy { get; set; }
        public string MonthYear { get; set; }
        public DateTime FirstDayOfMonth { get; set; }
        public DateTime LastDayOfMonth { get; set; }
        public DateTime FirstDayOfQuarter { get; set; }
        public DateTime LastDayOfQuarter { get; set; }
        public DateTime FirstDayOfYear { get; set; }
        public DateTime LastDayOfYear { get; set; }
        public DateTime FirstDayOfNextMonth { get; set; }
        public DateTime FirstDayOfNextYear { get; set; }
    }


    public static class DateMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.Date, TimecardRepository.Dates.Date>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Date object to Database object devTimecardDB.Date for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.Date ToDbModel(this TimecardRepository.Dates.Date repositoryObject)
        {
            return mapper.Map<devTimecardDB.Date>(repositoryObject);
        }


        /// <summary>
        /// Converts devTimecardDB.Date object to TimecardRepository.Models.Date object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Dates.Date ToRepositoryModel(this devTimecardDB.Date databaseObject)
        {
            return mapper.Map<TimecardRepository.Dates.Date>(databaseObject);
        }

    }
}

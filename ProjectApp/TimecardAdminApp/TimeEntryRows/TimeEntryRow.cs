using System;
using System.Collections.Generic;



using TimecardAdminApp.DateViews;
using TimecardAdminApp.Employees;
using TimecardAdminApp.TimecardViews;
using TimecardAdminApp.TimeEntryViews;


namespace TimecardAdminApp.TimeEntryRows
{
    public class TimeEntryRow
    {
        /// <summary>
        /// Selected Employee Record
        /// </summary>




        
        public string       SundayHours { get; set; }
        public string       MondayHours { get; set; }
        public string       TuesdayHours { get; set; }
        public string       WednesdayHours { get; set; }
        public string       ThursdayHours { get; set; }
        public string       FridayHours { get; set; }
        public string       SaturdayHours { get; set; }
        
        public string       TotalHours { get; set; }
        public string       Note { get; set; }

        public TimeEntryRow()
        {
            

        }



    }


    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class TimeEntryRowsMapperExtension
    {

        /*// Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.TimecardRows.TimecardRow, TimecardAdminApp.TimecardRows.TimecardRow>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.TimecardRows.TimecardRow ToRepositoryModel(this TimecardAdminApp.TimecardRows.TimecardRow applicationObject)
        {
            return mapper.Map<TimecardRepository.TimecardRows.TimecardRow>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.TimecardRows.TimecardRow ToUIModel(this TimecardRepository.TimecardRows.TimecardRow repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.TimecardRows.TimecardRow>(repositoryObject);
        }*/

    }
}

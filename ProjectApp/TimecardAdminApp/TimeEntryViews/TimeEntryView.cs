using System;
using System.Collections.Generic;
using AutoMapper;
using TimecardRepository;

namespace TimecardAdminApp.TimeEntryViews
{
    public class TimeEntryView
    {
        public string EntryGroup { get; set; }
        public string RowLabel { get; set; }
        public int TimeEntryKey { get; set; }
        public int CompanyKey { get; set; }
        public int TimeEntryViewKey { get; set; }
        public int PayrollDepartmentKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int JobKey { get; set; }
        public int CostCenterKey { get; set; }
        public int PhaseKey { get; set; }
        public int WeekEndDateKey { get; set; }
        public int DateKey { get; set; }
        public int Hours { get; set; }
        public string QuickNote { get; set; }
        public int EnteredByTimeEntryViewKey { get; set; }
        public DateTime EntryTime { get; set; }
        public int ModifiedByTimeEntryViewKey { get; set; }
        public DateTime ModifyTime { get; set; }
        public bool Approved { get; set; }
        public int ApprovedByTimeEntryViewKey { get; set; }
        public DateTime ApproveTime { get; set; }
        public bool Submitted { get; set; }
    }

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class TimeEntryViewMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.TimeEntryViews.TimeEntryView, TimecardAdminApp.TimeEntryViews.TimeEntryView>().ReverseMap());        
        public static IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.TimeEntryViews.TimeEntryView ToRepositoryModel(this TimecardAdminApp.TimeEntryViews.TimeEntryView applicationObject)
        {
            return mapper.Map<TimecardRepository.TimeEntryViews.TimeEntryView>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.TimeEntryViews.TimeEntryView ToUIModel(this TimecardRepository.TimeEntryViews.TimeEntryView repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.TimeEntryViews.TimeEntryView>(repositoryObject);
        }

    }
}

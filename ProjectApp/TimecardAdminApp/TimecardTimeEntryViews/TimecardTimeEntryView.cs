using System;
using System.Collections.Generic;

namespace TimecardAdminApp.TimecardTimeEntryViews
{
    public class TimecardTimeEntryView
    {
        public string EntryGroup { get; set; }
        public string RowLabel { get; set; }
        public int TimeEntryKey { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int PayrollDepartmentKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int? JobKey { get; set; }
        public int? PhaseKey { get; set; }
        public int? CostCenterKey { get; set; }
        public int WeekEndDateKey { get; set; }
        public int DateKey { get; set; }
        public int Hours { get; set; }
        public string QuickNote { get; set; }
        public int EnteredByEmployeeKey { get; set; }
        public DateTime EntryTime { get; set; }
        public int ModifiedByEmployeeKey { get; set; }
        public DateTime ModifyTime { get; set; }
        public bool Approved { get; set; }
        public int ApprovedByEmployeeKey { get; set; }
        public DateTime ApproveTime { get; set; }
        public bool Submitted { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int TimecardId { get; set; }
    }    
    
    
    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class TimecardTimeEntryViewMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryView, TimecardAdminApp.TimecardTimeEntryViews.TimecardTimeEntryView>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryView ToRepositoryModel(this TimecardAdminApp.TimecardTimeEntryViews.TimecardTimeEntryView applicationObject)
        {
            return mapper.Map<TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryView>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.TimecardTimeEntryViews.TimecardTimeEntryView ToUIModel(this TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryView repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.TimecardTimeEntryViews.TimecardTimeEntryView>(repositoryObject);
        }

    }

}

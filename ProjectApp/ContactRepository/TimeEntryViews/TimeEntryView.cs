using System;
using System.Collections.Generic;

namespace TimecardRepository.TimeEntryViews
{
    public partial class TimeEntryView
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



    public static class TimeEntryViewMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.TimeEntryView, TimecardRepository.TimeEntryViews.TimeEntryView>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.TimeEntryViews.TimeEntryView object to Database object devTimecardDB.TimeEntryView for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.TimeEntryView ToDbModel(this TimecardRepository.TimeEntryViews.TimeEntryView repositoryObject)
        {
            return mapper.Map<devTimecardDB.TimeEntryView>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.TimeEntryView object to TimecardRepository.TimeEntryViews.TimeEntryView object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.TimeEntryViews.TimeEntryView ToRepositoryModel(this devTimecardDB.TimeEntryView databaseObject)
        {
            return mapper.Map<TimecardRepository.TimeEntryViews.TimeEntryView>(databaseObject);
        }

    }

}

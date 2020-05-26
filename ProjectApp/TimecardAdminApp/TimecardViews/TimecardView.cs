using System;
using System.Collections.Generic;

namespace TimecardAdminApp.TimecardViews
{
    public class TimecardView
    {
        public int? Id { get; set; }
        public int CompanyKey { get; set; }
        public int TimecardViewKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int? JobKey { get; set; }
        public int? PhaseKey { get; set; }
        public int? CostCenterKey { get; set; }
        public int? AddedByTimecardViewKey { get; set; }
        public int? DateKey { get; set; }
        public string EntryGroup { get; set; }
        public string RowLabel { get; set; }
    }


    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class TimecardViewMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.TimecardViews.TimecardView, TimecardAdminApp.TimecardViews.TimecardView>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.TimecardViews.TimecardView ToRepositoryModel(this TimecardAdminApp.TimecardViews.TimecardView applicationObject)
        {
            return mapper.Map<TimecardRepository.TimecardViews.TimecardView>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.TimecardViews.TimecardView ToUIModel(this TimecardRepository.TimecardViews.TimecardView repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.TimecardViews.TimecardView>(repositoryObject);
        }

    }
}

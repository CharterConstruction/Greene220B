using System;
using System.Collections.Generic;

namespace TimecardRepository.TimecardViews
{
    public partial class TimecardView
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

    public static class TimecardViewMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.TimecardView, TimecardRepository.TimecardViews.TimecardView>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.TimecardView object to Database object devTimecardDB.TimecardView for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.TimecardView ToDbModel(this TimecardRepository.TimecardViews.TimecardView repositoryObject)
        {
            return mapper.Map<devTimecardDB.TimecardView>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.TimecardView object to TimecardRepository.Models.TimecardView object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.TimecardViews.TimecardView ToRepositoryModel(this devTimecardDB.TimecardView databaseObject)
        {
            return mapper.Map<TimecardRepository.TimecardViews.TimecardView>(databaseObject);
        }

    }
}

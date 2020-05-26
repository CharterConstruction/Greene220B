using System;
using System.Collections.Generic;

namespace TimecardRepository.Timecards
{
    public class Timecard
    {
        public int Id { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public string PayrollDepartmentCode { get; set; }
        public int JobKey { get; set; }
        public int PhaseKey { get; set; }
        public int CostCenterKey { get; set; }
        public int AddedByEmployeeKey { get; set; }
        public int DateKey { get; set; }
        public string EntryGroup { get; set; }
        public string RowLabel { get; set; }
        public string Discriminator { get; set; }
    }

    public static class TimecardMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.Timecard, TimecardRepository.Timecards.Timecard>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Timecard object to Database object devTimecardDB.Timecard for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.Timecard ToDbModel(this TimecardRepository.Timecards.Timecard repositoryObject)
        {
            return mapper.Map<devTimecardDB.Timecard>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.Timecard object to TimecardRepository.Models.Timecard object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Timecards.Timecard ToRepositoryModel(this devTimecardDB.Timecard databaseObject)
        {
            return mapper.Map<TimecardRepository.Timecards.Timecard>(databaseObject);
        }

    }
}

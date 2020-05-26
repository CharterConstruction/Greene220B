using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;

//REPOSITORY MODEL
namespace TimecardRepository.Jobs
{
    public partial class Job
    {
        public int JobKey { get; set; }
        public int CompanyKey { get; set; }
        public string JobNumber { get; set; }
        public string JobName { get; set; }
        public string JobNumberName { get; set; }
        public int CostCenterKey { get; set; }
        public string JobStatus { get; set; }
        public decimal ContractAmount { get; set; }
        public string ProjectManager { get; set; }
        public string Superintendent { get; set; }
        public string AddressZipFull { get; set; }
        public string AddressFull { get; set; }
        public bool IsCertified { get; set; }
        public int Level { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsMyJob { get; set; }
        public bool IsTimecardJob { get; set; }
        public bool IsTeamJob { get; set; }
    }

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class JobMapperExtension 
    {
        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.Job, TimecardRepository.Jobs.Job>().ReverseMap());
        public static IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Job object to Database object devTimecardDB.Job for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.Job ToDbModel(this TimecardRepository.Jobs.Job repositoryObject)
        {
            return mapper.Map<devTimecardDB.Job>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.Job object to TimecardRepository.Models.Job object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Jobs.Job ToRepositoryModel(this devTimecardDB.Job databaseObject)
        {
            return mapper.Map<TimecardRepository.Jobs.Job>(databaseObject);
        }

    }
         
}

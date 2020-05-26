using System;
using System.Collections.Generic;
using AutoMapper;
using TimecardRepository;

namespace TimecardAdminApp.Models
{
    public class Job
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

        public TimecardAdminApp.Models.Job Clone()
        {
            return (TimecardAdminApp.Models.Job)MemberwiseClone();
        }
    }

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class JobExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<TimecardAdminApp.Models.Job, TimecardRepository.Models.Job>().ReverseMap());
        public static IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Job object to Database object TimecardRepository.Models.Job for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Models.Job ToRepositoryModel(this TimecardAdminApp.Models.Job applicationObject)
        {
            return mapper.Map<TimecardRepository.Models.Job>(applicationObject);
        }

        /// <summary>
        /// Converts TimecardRepository.Models.Job object to TimecardRepository.Models.Job object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.Models.Job ToUIModel(this TimecardRepository.Models.Job repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.Models.Job>(repositoryObject);
        }

    }
}

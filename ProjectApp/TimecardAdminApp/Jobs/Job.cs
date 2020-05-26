using System;
using System.Collections.Generic;
using AutoMapper;
using TimecardRepository;

/// <summary>
/// Application Models
/// </summary>

namespace TimecardAdminApp.Jobs
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

        public Job Clone()
        {
            return (Job)MemberwiseClone();
        }
    }

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class JobMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.Jobs.Job, TimecardAdminApp.Jobs.Job>().ReverseMap());        
        public static IMapper mapper = mapperConfig.CreateMapper();
                

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Jobs.Job ToRepositoryModel(this TimecardAdminApp.Jobs.Job applicationObject)
        {
            return mapper.Map <TimecardRepository.Jobs.Job> (applicationObject);
        }

        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.Jobs.Job ToUIModel(this TimecardRepository.Jobs.Job repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.Jobs.Job>(repositoryObject);
        }

    }
}

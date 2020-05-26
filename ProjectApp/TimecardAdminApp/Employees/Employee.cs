using System;
using System.Collections.Generic;
using TimecardRepository;

/// <summary>
/// Application Models
/// </summary>

namespace TimecardAdminApp.Employees
{
    public class Employee
    {
        public int EmployeeKey { get; set; }
        public int CompanyKey { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeeTitle { get; set; }
        public int CostCenterKey { get; set; }
        public string EmployeeTeam { get; set; }
        public string EmployeeAdUpn { get; set; }
        public string EmployeeWorkersCompCode { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsField { get; set; }
        public int TimecardAccess { get; set; }
    }
    

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class EmployeeMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.Employees.Employee, TimecardAdminApp.Employees.Employee>().ReverseMap());        
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Employees.Employee ToRepositoryModel(this TimecardAdminApp.Employees.Employee applicationObject)
        {
            return mapper.Map<TimecardRepository.Employees.Employee>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.Employees.Employee ToUIModel(this TimecardRepository.Employees.Employee repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.Employees.Employee>(repositoryObject);
        }

    }




}

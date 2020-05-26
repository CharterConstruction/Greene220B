using System;
using System.Collections.Generic;
using AutoMapper;
using static Common.ModelMapper<devTimecardDB.Employee, TimecardRepository.Employees.Employee>;


namespace TimecardRepository.Employees
{
    public partial class Employee
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

    public static class EmployeeMapperExtension
    {

        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.Employee, TimecardRepository.Employees.Employee>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Employee object to Database object devTimecardDB.Employee for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.Employee ToDbModel(this TimecardRepository.Employees.Employee repositoryObject)
        {
            return mapper.Map<devTimecardDB.Employee>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.Employee object to TimecardRepository.Models.Employee object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.Employees.Employee ToRepositoryModel(this devTimecardDB.Employee databaseObject)
        {
            return mapper.Map<TimecardRepository.Employees.Employee>(databaseObject);
        }

    }

    /*
    public static class EmployeeMapperExtension
    {
        public static devTimecardDB.Employee ToDbModel(this Employee repositoryObject)
        {
            return ToDbModel(repositoryObject);
        }

        public static TimecardRepository.Employees.Employee ToRepositoryModel(this devTimecardDB.Employee databaseObject)
        {
            return ToRepositoryModel(databaseObject);
        }



    }

    */
    /*
    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>

    */





}

using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using static Common.ModelMapper<devTimecardDB.ManagerEmployee, TimecardRepository.ManagerEmployees.ManagerEmployee>;


namespace TimecardRepository.ManagerEmployees
{
    public partial class ManagerEmployee
    {
        public int Id { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int ManagerKey { get; set; }
    }


    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class ManagerEmployeeMapperExtension
    {
        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<devTimecardDB.ManagerEmployee, TimecardRepository.ManagerEmployees.ManagerEmployee>().ReverseMap());
        public static IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.ManagerEmployee object to Database object devTimecardDB.ManagerEmployee for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static devTimecardDB.ManagerEmployee ToDbModel(this TimecardRepository.ManagerEmployees.ManagerEmployee repositoryObject)
        {
            return mapper.Map<devTimecardDB.ManagerEmployee>(repositoryObject);
        }

        /// <summary>
        /// Converts devTimecardDB.ManagerEmployee object to TimecardRepository.Models.ManagerEmployee object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.ManagerEmployees.ManagerEmployee ToRepositoryModel(this devTimecardDB.ManagerEmployee databaseObject)
        {
            return mapper.Map<TimecardRepository.ManagerEmployees.ManagerEmployee>(databaseObject);
        }

    }


    /*
    public static class ManagerEmployeeMapperExtension
    {
        public static devTimecardDB.ManagerEmployee ToDbModel(this ManagerEmployee repositoryObject)
        {
            return ToDbModel(repositoryObject);
        }

        public static TimecardRepository.ManagerEmployees.ManagerEmployee ToRepositoryModel(this devTimecardDB.ManagerEmployee databaseObject)
        {
            return ToRepositoryModel(databaseObject);
        }
    }
    */






}

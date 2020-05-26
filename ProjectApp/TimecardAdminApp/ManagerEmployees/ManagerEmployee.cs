using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using static TimecardAdminApp.Employees.EmployeeMapperExtension;

namespace TimecardAdminApp.ManagerEmployees
{
    public partial class ManagerEmployee
    {

        public int Id { get; set; }
        public int CompanyKey { get; set; }
        public int EmployeeKey { get; set; }
        public int ManagerKey { get; set; }

        public string EmployeeName
        {
            get
            {
                var Employee = new TimecardRepository.Employees.EmployeeRepository().Query()
                    .Where(t => t.EmployeeKey == this.EmployeeKey)
                    .Select(t => t.ToUIModel())
                    .FirstOrDefault();

                if (Employee != null)                
                    return Employee.EmployeeName;                
                else                
                    return "Employee Not Found";
            }
        }

        public ManagerEmployee Clone()
        {
            return (ManagerEmployee)MemberwiseClone();
        }

    }

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class ManagerEmployeeMapperExtension
    {
        // Create AutoMapper configuration for mapping repository model objects to application model objects        
        public static MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<TimecardRepository.ManagerEmployees.ManagerEmployee, TimecardAdminApp.ManagerEmployees.ManagerEmployee>().ReverseMap());
        public static IMapper mapper = mapperConfig.CreateMapper();


        //Database <-> Repository

        /// <summary>
        /// Convert Database object to Repository object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardRepository.ManagerEmployees.ManagerEmployee ToRepositoryModel(this TimecardAdminApp.ManagerEmployees.ManagerEmployee applicationObject)
        {
            return mapper.Map<TimecardRepository.ManagerEmployees.ManagerEmployee>(applicationObject);
        }


        /// <summary>
        /// Convert Repository object to Application object
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static TimecardAdminApp.ManagerEmployees.ManagerEmployee ToUIModel(this TimecardRepository.ManagerEmployees.ManagerEmployee repositoryObject)
        {
            return mapper.Map<TimecardAdminApp.ManagerEmployees.ManagerEmployee>(repositoryObject);
        }

    }




}

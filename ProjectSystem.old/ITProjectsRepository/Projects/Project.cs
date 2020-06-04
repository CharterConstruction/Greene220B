using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ITPM.Repository.Statuses;

namespace ITPM.Repository.Projects
{
    public class Project
    {
        public int ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public string ProjectConcept { get; set; }
        public int StageKey { get; set; }
        public int StatusKey { get; set; }

    }

    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class ProjectMapper
    {
        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<ITPM.Database.Project, ITPM.Repository.Projects.Project>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();

        /// <summary>
        /// Converts TimecardRepository.Models.Project object to Database object ITPM.Database.Project for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.Database.Project ToDbModel(this ITPM.Repository.Projects.Project repositoryObject)
        {
            return mapper.Map<ITPM.Database.Project>(repositoryObject);
        }

        /// <summary>
        /// Converts ITPM.Database.Project object to TimecardRepository.Models.Project object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.Repository.Projects.Project ToRepositoryModel(this ITPM.Database.Project databaseObject)
        {
            return mapper.Map<ITPM.Repository.Projects.Project>(databaseObject);
        }

    }

}

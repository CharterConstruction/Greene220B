using System;
using System.Collections.Generic;
using System.Text;
using ITPM.App.Statuses;
using System.Linq;

namespace ITPM.App.Projects
{
    public class Project : BindableBase
    {

        private int _projectKey;
        public int ProjectKey { 
            get { return _projectKey;  }
            set { SetProperty(ref _projectKey, value); } 
        }

        private string _projectName;
        public string ProjectName
        {
            get { return _projectName; }
            set { SetProperty(ref _projectName, value); }
        }

        private string _projectConcept;
        public string ProjectConcept
        {
            get { return _projectConcept; }
            set { SetProperty(ref _projectConcept, value); }
        }

        private int _stageKey;
        public int StageKey
        {
            get { return _stageKey; }
            set { SetProperty(ref _stageKey, value); }
        }

        /*
        private int _statusKey;
        public int StatusKey
        {
            get { return _statusKey; }
            set { SetProperty(ref _statusKey, value); }
        }
        */


        private Status _status;
        public Status Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }


    }



    
    
    /// <summary>
    /// Extension classes for the TimecardRepository.Models.Class
    /// </summary>
    public static class ProjectMapper
    {
        // Create AutoMapper configuration for mapping database model objects to repository model objects
        public static AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg => cfg.CreateMap<ITPM.Repository.Projects.Project, ITPM.App.Projects.Project>().ReverseMap());
        public static AutoMapper.IMapper mapper = mapperConfig.CreateMapper();
        private static ITPM.Repository.Statuses.StatusRepository _statusRepository = new ITPM.Repository.Statuses.StatusRepository();

        /// <summary>
        /// Converts TimecardRepository.Models.Project object to Database object ITPM.Repository.Projects.Project for CRUD operations.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.Repository.Projects.Project ToRepositoryModel(this Project appObject)
        {
            ITPM.Repository.Projects.Project output = mapper.Map<ITPM.Repository.Projects.Project>(appObject);

            output.StatusKey = appObject.Status.StatusKey;

            return output;
        }

        /// <summary>
        /// Converts ITPM.Repository.Projects.Project object to TimecardRepository.Models.Project object.
        /// </summary>
        /// <param name="databaseObject"></param>
        /// <returns></returns>
        public static ITPM.App.Projects.Project ToUIModel(this ITPM.Repository.Projects.Project repositoryObject)
        {
            Project output = mapper.Map<Project>(repositoryObject);
            output.Status = _statusRepository.GetAll().Where(t => t.StatusKey == repositoryObject.StatusKey).Select(t => t.ToUIModel()).FirstOrDefault();
            
            return output;

            //return mapper.Map<ITPM.App.Projects.Project>(repositoryObject);
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;

//using ITProjectsRepository;
//using static ITProjectsRepository.ProjectRepository;

using ITPM.ViewModels.Models;

namespace ITPM.ViewModels
{
    public class ProjectsViewModel
    {

        internal static ITProjectsRepository.ProjectRepository projectRepo = null;
        internal List<ProjectModel> projectList = null;


        public ProjectsViewModel()
        {                       
            projectRepo = new ITProjectsRepository.ProjectRepository();
            LoadProjects();
        }

        /// <summary>
        /// Converts repository model objects into view model objects.  
        /// </summary>
        public void LoadProjects()
        {
            projectList = ProjectRepository.GetAll().Select(repoModel => ProjectModel.ToModel(repoModel)).ToList();
        }
               

        public ITProjectsRepository.ProjectRepository ProjectRepository
        {
            get
            {
                return projectRepo;
            }
        }

        public List<ProjectModel> Projects
        {
            get
            {
                return projectList;
            }
        }



    }



}


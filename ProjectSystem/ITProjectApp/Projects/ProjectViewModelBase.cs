using System;
using System.Collections.Generic;
using System.Text;

namespace ITPM.App.Projects
{
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Data;
    using ITPM.App.Statuses;


    public class ProjectViewModelBase : BindableBase
    {

        // Relay commands are for binding UI elements and relaying parameters...        
        
        public RelayCommand             LoadProjectsCommand { get; private set; }
        public RelayCommand<Project>    SelectProjectCommand { get; private set; }

        public RelayCommand             AddProjectCommand { get; private set; }
        public RelayCommand<Project>    SaveProjectCommand { get; private set; }
        public RelayCommand<Project>    DeleteProjectCommand { get; private set; }
        


        // Commands  for relaying data or notifying other view models of actions performed.
        public event Action LoadProjectsRequested = delegate { };
        public event Action<Project> SelectProjectRequested = delegate { };

        public event Action<Project> AddProjectRequested = delegate { };
        public event Action<Project> SaveProjectRequested = delegate { };
        public event Action<Project> DeleteProjectRequested = delegate { };


        // Any repositories we need to interact with
        private static ITPM.Repository.Projects.ProjectRepository _projectRepository = new ITPM.Repository.Projects.ProjectRepository();
        private static ITPM.Repository.Statuses.StatusRepository _statusRepository = new ITPM.Repository.Statuses.StatusRepository();


        // Default fields
        public readonly Status _defaultProjectStatus = StatusRepository.GetAll().Where(t => t.StatusName == "New Idea").Select(t => t.ToUIModel()).FirstOrDefault();

        // UI Data
        private Project _selectedProject = null;

        private Status _selectedProjectStatus = null;
               
        private List<Project> _projects = null;
        
        internal ICollectionView _projectsView = null;



        public ProjectViewModelBase()
        {
            OnLoadProjects();
            _projectsView = CollectionViewSource.GetDefaultView(_projects as IList<Project>);


            // Listen for the UI to execute the following commands:
            LoadProjectsCommand = new RelayCommand(OnLoadProjects);
            SelectProjectCommand = new RelayCommand<Project>(OnSelectProject);
            
            AddProjectCommand = new RelayCommand(OnAddProject);
            SaveProjectCommand = new RelayCommand<Project>(OnSaveProject);
            DeleteProjectCommand = new RelayCommand<Project>(OnDeleteProject);
        }







        // Any repositories we need to interact with
        public static ITPM.Repository.Projects.ProjectRepository ProjectRepository
        {
            get { return _projectRepository; }
        }

        public static ITPM.Repository.Statuses.StatusRepository StatusRepository
        {
            get { return _statusRepository; }
        }


        public Project SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value;
                OnPropertyChanged("SelectedProject");
                OnPropertyChanged("Statuses");
                SetProperty(ref _selectedProject, value);
            }
        }



        public Status SelectedProjectStatus
        {
            get
            {
                return _selectedProjectStatus;
            }
            set
            {
                _selectedProjectStatus = value;
                SetProperty(ref _selectedProjectStatus, value);
                OnPropertyChanged("SelectedProjectStatus");
            }
        }

        public ICollectionView Projects
        {
            get { return _projectsView; }
        }




        internal Project NewProjectConcept()
        {
            return new Project()
            {
                Status = _defaultProjectStatus
            };
        }



        /// <summary>
        /// RelayCommand Method that returns a new project.  
        /// Listen from other viewModels by subscribing to actions of this view model by adding a line such as:
        /// _projectListViewModel.AddProjectRequested += ParentViewModelMethodToExecute;
        /// </summary>
        /// <returns></returns>
        public void OnAddProject()
        {
            AddProjectRequested(NewProjectConcept());
        }


        public void OnSelectProject(Project selectedProject)
        {
            //Comment this out to see if it's what's actually what
            //OnSelectProject(selectedProject);
            SelectProjectRequested(selectedProject);
            
            SelectedProject = selectedProject;
            SelectedProjectStatus = selectedProject.Status;
        }


        /*private void OnReloadProjects()
        {
            LoadProjects();
        }*/

        public void OnLoadProjects()
        {            
            LoadProjectsRequested();
            _projects = ProjectRepository.GetAll().Select(t => t.ToUIModel()).ToList();
        }

        public void OnSaveProject(Project project)
        {
            Project updated = SaveProjectToDatabase(project);
            SaveProjectRequested(updated);
        }




        public Project SaveProjectToDatabase(Project project)
        {
            Project updatedProject = new Project();
            
            if (project.ProjectKey > 0)
            {
                bool projectUpdated = ProjectRepository.Update(project.ToRepositoryModel());
                if (projectUpdated)
                    updatedProject = project;
                
                

            }
            else
            {
                Project returnedProject = ProjectRepository.Add(project.ToRepositoryModel()).ToUIModel();
                
                if(returnedProject.ProjectKey > 0 )
                    updatedProject = returnedProject;
            }


            return updatedProject;

        }



        public void OnDeleteProject(Project project)
        {
            SaveProjectRequested(project);

            SaveProjectToDatabase(project);
        }






        public bool DeleteProjectFromDatabase(Project project)
        {
            bool projectDeleted = false;
            
            if (project.ProjectKey > 0)
            {
                projectDeleted = ProjectRepository.Remove(project.ProjectKey);
            }

            return projectDeleted;

        }










    }
}

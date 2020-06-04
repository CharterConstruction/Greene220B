using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


namespace ITPM.App
{
    using MahApps.Metro.Controls;
    using System.Linq;
    using ITPM.App.Projects;
    using ITPM.App.Statuses;
    using System.Windows.Data;

    class MainWindowViewModel : BindableBase
    {


        private static ITPM.Repository.Projects.ProjectRepository _projectRepository = new ITPM.Repository.Projects.ProjectRepository();
        private static ITPM.Repository.Statuses.StatusRepository _statusRepository = new ITPM.Repository.Statuses.StatusRepository();
        private readonly Status _defaultProjectStatus = _statusRepository.GetAll().Where(t => t.StatusName == "New Idea").Select(t => t.ToUIModel()).FirstOrDefault();
        
        private BindableBase _CurrentListViewModel;
        private BindableBase _CurrentDetailViewModel;

        private ProjectListViewModel _projectListViewModel = new ProjectListViewModel();
        private AddEditProjectViewModel _addEditProjectViewModel = new AddEditProjectViewModel();

        public MainWindowViewModel()
        {
            // Requestable commands
            NavCommand = new RelayCommand<string>(OnNav);
            

            // Subscribe to the actions of child view models in order to invoke change on related view models.
            _projectListViewModel.AddProjectRequested += SetCurrentProject;

            _projectListViewModel.LoadProjectsRequested += ReloadProjects;
            _projectListViewModel.SelectProjectRequested += SetCurrentProject;
            _projectListViewModel.DeleteProjectRequested += DeleteProjectAndAddNew;

            _addEditProjectViewModel.SaveProjectRequested += SetCurrentProject;
            _addEditProjectViewModel.LoadProjectsRequested += ReloadProjects;
            _addEditProjectViewModel.DeleteProjectRequested += DeleteProjectAndAddNew;
            
            CurrentListViewModel = _projectListViewModel;

        }



        public BindableBase CurrentListViewModel
        {
            get { return _CurrentListViewModel; }
            set { SetProperty(ref _CurrentListViewModel, value); }
        }



        public BindableBase CurrentDetailViewModel
        {
            get { return _CurrentDetailViewModel; }
            set { SetProperty(ref _CurrentDetailViewModel, value); }
        }

        
        private void ReloadProjects()
        {       
           _projectListViewModel.LoadProjectCollection();          
            CurrentListViewModel = _projectListViewModel;
        }



        private void SetCurrentProject(Project project)
        {

            _addEditProjectViewModel.OnSelectProject(project);
            CurrentDetailViewModel = _addEditProjectViewModel;

        }

        private void DeleteProjectAndAddNew(Project project)
        {
            _projectListViewModel.LoadProjectCollection();
            _projectListViewModel.OnAddProject();

            CurrentListViewModel = _projectListViewModel;
            
        }




        public RelayCommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "ProjectSelect":
                    CurrentListViewModel = _projectListViewModel;
                    break;

                default:
                    break;
            }
        }




    }
}

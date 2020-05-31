using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


namespace ITPM.App
{
    using System.Linq;
    using ITPM.App.Projects;
    using ITPM.App.Statuses;

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
            //ReloadProjectsCommand = new RelayCommand(OnReloadProjectsRequested);


            // ProjectListViewModel ACTION subscriptions - when these events occur, do things here.
            _projectListViewModel.AddProjectRequested += SetCurrentProject;
            _projectListViewModel.SelectProjectRequested += SetCurrentProject;
            _addEditProjectViewModel.SaveProjectRequested += SetCurrentProject;

            
            
            //_addEditProjectViewModel.LoadProjectsRequested += OnReloadProjectsRequested;

            //to do... listen for delete and reload...?




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
            _projectListViewModel.OnLoadProjects();
        }



        private void SetCurrentProject(Project project)
        {
            _addEditProjectViewModel.OnSelectProject(project);               
                
            CurrentDetailViewModel = _addEditProjectViewModel;
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


        /*
        public RelayCommand ReloadProjectsCommand { get; private set; }
        public event Action ReloadProjectsRequested = delegate { };

        private void OnReloadProjectsRequested()
        {
            ReloadProjectsRequested();
            //_projectListViewModel.LoadProjects();
        }*/

    }
}

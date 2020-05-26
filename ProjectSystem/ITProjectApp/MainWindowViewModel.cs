using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using ITPM.App.Projects;

namespace ITPM.App
{
    class MainWindowViewModel : BindableBase
    {

        
        private BindableBase _CurrentListViewModel;
        private BindableBase _CurrentDetailViewModel;

        private ProjectListViewModel _projectListViewModel = new ProjectListViewModel();
        private AddEditProjectViewModel _addEditProjectViewModel = new AddEditProjectViewModel();


        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);

            //Subscribe to child view model events to know when to update UI
            _projectListViewModel.AddProjectRequested += SetSelectedProject;
            _projectListViewModel.EditProjectRequested += SetSelectedProject;
            _projectListViewModel.DeleteProjectRequested += SetSelectedProject;            

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



        private void SetSelectedProject(Project project)
        {
            //    _addEditProjectViewModel.SelectedProject = project;


            _addEditProjectViewModel.SetProject(project);
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





    }
}

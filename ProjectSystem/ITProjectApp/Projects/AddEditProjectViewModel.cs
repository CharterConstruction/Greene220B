
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using ITPM.App.Statuses;

namespace ITPM.App.Projects
{
    public class AddEditProjectViewModel : ProjectListViewModel
    {
        private static ITPM.Repository.Statuses.StatusRepository _statusRepository = new ITPM.Repository.Statuses.StatusRepository();

        private bool _editMode;
        public bool EditMode
        {
            get { return _editMode; }
            set{ SetProperty(ref _editMode, value); }
        }



        public AddEditProjectViewModel()
        {
            _statusList = _statusRepository.GetAll().Select(t => t.ToUIModel()).ToList();

            SaveProjectCommand = new RelayCommand<Project>(OnSaveProject);
        }





        private List<Status> _statusList = null;
        public ObservableCollection<Status> Statuses
        {
            get { return new ObservableCollection<Status>(_statusList); }
        }


        private Project _selectedProject = null;
        
        public Project SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value;                
                OnPropertyChanged("SelectedProject");  
                SetProperty(ref _selectedProject, value);
            }
        }


        private Status _selectedProjectStatus = null;
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




        public void SetProject(Project project)
        {
            SelectedProject = project;
            SelectedProjectStatus = project.Status;
        }





        public void TestMethod()
        {
            MessageBox.Show($"Current Project is {SelectedProject.ProjectName}");
        }


        // ICommand Pattern
        public RelayCommand<Project> SaveProjectCommand { get; private set; }
        public event Action<Project> SaveProjectRequested = delegate { };
        
        private void OnSaveProject(Project project)
        {
         //   project.Status = SelectedProjectStatus;
            MessageBox.Show($"Previously SelectedProject.Status {SelectedProject.Status.StatusName} and... SelectedProjectStatus: {SelectedProjectStatus.StatusName}");
            SaveProjectRequested(project);
            _projectRepository.Update(project.ToRepositoryModel());

        }

      

    }
}

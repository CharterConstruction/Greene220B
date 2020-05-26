using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Data;


using ITPM.App.Statuses;

namespace ITPM.App.Projects
{
    public class ProjectListViewModel : BindableBase
    {
        internal static ITPM.Repository.Projects.ProjectRepository _projectRepository = new ITPM.Repository.Projects.ProjectRepository();




        private List<Project> _projects = null;        
        private ICollectionView _projectsView = null;
        public ICollectionView Projects
        {
            get { return _projectsView; }
        }


        public ProjectListViewModel()
        {
            Load();
            _projectsView = CollectionViewSource.GetDefaultView(_projects as IList<Project>);
            _projectsView.Filter = Filter;

            AddProjectCommand = new RelayCommand<Project>(OnAddProject);
            EditProjectCommand = new RelayCommand<Project>(OnEditProject);
            DeleteProjectCommand = new RelayCommand<Project>(OnDeleteProject);

        }


        private string _searchString = null;
        public string SearchString
        {
            get { return _searchString; }
            set
            {
                _searchString = value;
                OnPropertyChanged("SearchString");
                Projects.Refresh();
            }
        }

        public void Load()
        {
            _projects = _projectRepository.GetAll().Select(t => t.ToUIModel()).ToList();
        }

        private bool Filter(object item)
        {
            Project employee = item as Project;

            return SearchString == null
                || employee.ProjectName.Contains(_searchString);
        }


        // ICommand Pattern
        public RelayCommand<Project> AddProjectCommand { get; private set; }
        public RelayCommand<Project> EditProjectCommand { get; private set; }
        public RelayCommand<Project> DeleteProjectCommand { get; private set; }


        public event Action<Project> AddProjectRequested = delegate { };
        public event Action<Project> EditProjectRequested = delegate { };
        public event Action<Project> DeleteProjectRequested = delegate { };

              

        private void OnAddProject(Project project)
        {
            AddProjectRequested(project);
        }

        private void OnEditProject(Project project)
        {
            EditProjectRequested(project);
        }

        private void OnDeleteProject(Project project)
        {
            DeleteProjectRequested(project);
        }


    }
}
 
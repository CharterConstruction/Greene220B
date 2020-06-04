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
    public class ProjectListViewModel : ProjectViewModelBase
    {

        
        public ProjectListViewModel()
        {            
            //_projectsView.Filter = Filter;
        }




        private string _searchString = null;
        public string SearchString
        {
            get { return _searchString; }
            set
            {
                _searchString = value;
                ProjectCollection = new ObservableCollection<Project>(_projects.Where(t => t.ProjectName.Contains(value)).ToList());
                OnPropertyChanged("SearchString");            
                
            }
        }





        /*
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
        }*/


        private bool Filter(object item)
        {
            Project project = item as Project;

            return SearchString == null
                || project.ProjectName.Contains(_searchString);
        }






               

    }
}
 
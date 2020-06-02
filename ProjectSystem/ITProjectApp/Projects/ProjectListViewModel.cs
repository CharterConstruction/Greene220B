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
                OnPropertyChanged("SearchString");
                Projects.Refresh();
            }
        }


        private bool Filter(object item)
        {
            Project employee = item as Project;

            return SearchString == null
                || employee.ProjectName.Contains(_searchString);
        }






               

    }
}
 
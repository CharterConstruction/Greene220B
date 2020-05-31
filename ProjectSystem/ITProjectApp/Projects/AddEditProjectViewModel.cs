
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using ITPM.App.Statuses;

namespace ITPM.App.Projects
{
    public class AddEditProjectViewModel : ProjectViewModelBase
    {
        
        private List<Status> _statusList = null;
        private ICollectionView _statusView = null;

        
        

        public AddEditProjectViewModel()
        {
            _statusList = StatusRepository.GetAll().Select(t => t.ToUIModel()).ToList();
            _statusView = CollectionViewSource.GetDefaultView(_statusList as IList<Status>);

         


        }


        public ICollectionView Statuses
        {
            get { return _statusView; }
        }
        


        
       







    }
}

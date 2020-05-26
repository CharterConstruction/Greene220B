using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;


namespace TimecardAdminApp.ManagerEmployees
{
    class ManagerEmployeeListViewModel: BindableBase
    { 
        /*
        private TimecardRepository.ManagerEmployees.ManagerEmployeeRepository _repo = new TimecardRepository.ManagerEmployees.ManagerEmployeeRepository();

               
        public ManagerEmployeeListViewModel()
        {
            LoadManagerEmployees();
        }
        
        private ObservableCollection<TimecardAdminApp.ManagerEmployees.ManagerEmployee> _ManagerEmployees;
        public ObservableCollection<TimecardAdminApp.ManagerEmployees.ManagerEmployee> ManagerEmployees
        {
            get { return _ManagerEmployees; }
            set { SetProperty(ref _ManagerEmployees, value); }
        }

        public void LoadManagerEmployees()
        {
            _ManagerEmployees = new ObservableCollection<TimecardAdminApp.ManagerEmployees.ManagerEmployee>(
                _repo.GetAll().Select(t => t.ToUIModel())
            );                
        }*/
         
    }
}

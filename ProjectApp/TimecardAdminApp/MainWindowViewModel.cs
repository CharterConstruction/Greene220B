using System;
using System.Collections.Generic;
using System.Text;

using TimecardAdminApp.DateViews;
using TimecardAdminApp.Employees;
using TimecardAdminApp.TimecardTimeEntryViews;

using TimecardAdminApp.Jobs;


namespace TimecardAdminApp
{
    class MainWindowViewModel : BindableBase
    {

        private BindableBase _CurrentTopViewModel;
        private BindableBase _CurrentListViewModel;
        private BindableBase _CurrentDetailViewModel;

        //private DateListViewModel _employeeListViewModel = new EmployeeListViewModel();


        private WeekViewModel _weekSelectView = new WeekViewModel();
        private EmployeeListViewModel _employeeListViewModel = new EmployeeListViewModel();
        private TimecardTimeEntryViewUIModel _timecardTimeEntryViewUIModel = new TimecardTimeEntryViewUIModel();
        private JobListViewModel _jobListViewModel = new JobListViewModel();
        


        //per employee        
        //private List<Date> _seletedWeek = null;
        //private Date _selectedDate = null;
        private Employee _selectedEmployee = null;
        //private TimecardTimeEntryView _selectedTimecard = null;


        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _employeeListViewModel.EmployeeSelected += SetSelectedEmployee;
                        
            CurrentTopViewModel = _weekSelectView;
            CurrentListViewModel = _employeeListViewModel;
            CurrentDetailViewModel = _timecardTimeEntryViewUIModel;

        }

        


        public RelayCommand<string> NavCommand { get; private set; }

        public BindableBase CurrentTopViewModel
        {
            get { return _CurrentTopViewModel; }
            set { SetProperty(ref _CurrentTopViewModel, value); }
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



        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { SetProperty(ref _selectedEmployee, value); }
        }



        private void SetSelectedEmployee(Employee employee)
        {
            SelectedEmployee = employee;
            _timecardTimeEntryViewUIModel = new TimecardTimeEntryViewUIModel(employee);
            OnNav("EmployeeTimeEntry");

        }


        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "EmployeeSelect":
   
                    CurrentListViewModel = _employeeListViewModel;
                    CurrentDetailViewModel = null;
                    break;

                case "EmployeeTimeEntry":
                    CurrentListViewModel = _employeeListViewModel;
                    CurrentDetailViewModel = _timecardTimeEntryViewUIModel;
                    break;

                default:                    
                    break;
            }
        }





    }
}

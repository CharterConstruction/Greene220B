using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Linq;


//Dates
using TimecardAdminApp.Dates;
//using static TimecardRepository.Dates.DateMapperExtension;

//Employees
using TimecardAdminApp.Employees;
//using static TimecardRepository.Employees.EmployeeMapperExtension;

//Timecards
using TimecardAdminApp.TimecardViews;
//using static TimecardRepository.TimecardViews.TimecardViewMapperExtension;

//TimeEntryViews
//using TimecardAdminApp.TimeEntryViews;
//using static TimecardRepository.TimeEntryViews.TimeEntryViewMapperExtension;

//TimeEntryViews
using TimecardAdminApp.TimecardTimeEntryViews;



/*
Create view model to act as timecard entry view model??

Needs
0) Select Week/Dates
1) List, Filter, Search Employees
-Select Employee and Load Timecard and Time Entries
2) List EntryGroups/Timecard
-Select and update 
3) 



*/

namespace TimecardAdminApp
{
    public class TimecardTestViewModel : BindableBase
    {

        // Repositories
        private static TimecardRepository.Dates.DateRepository _dateRepository = new TimecardRepository.Dates.DateRepository();
        private static TimecardRepository.Employees.EmployeeRepository _employeeRepository = new TimecardRepository.Employees.EmployeeRepository();
        private static TimecardRepository.TimecardViews.TimecardViewRepository _timecardRepository = new TimecardRepository.TimecardViews.TimecardViewRepository();
        //private static TimecardRepository.TimeEntryViews.TimeEntryViewRepository _timeEntryViewRepository = new TimecardRepository.TimeEntryViews.TimeEntryViewRepository();
        private static TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryViewRepository _timecardTimeEntryViewRepository = new TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryViewRepository();

        // Locally cached data
        private ObservableCollection<TimecardAdminApp.Dates.Date> _dates;
        private ObservableCollection<TimecardAdminApp.Employees.Employee> _employees;
        private ObservableCollection<TimecardAdminApp.TimecardViews.TimecardView> _timecards;
        //private ObservableCollection<TimecardAdminApp.TimeEntryViews.TimeEntryView> _timeEntries;
        private ObservableCollection<TimecardAdminApp.TimecardTimeEntryViews.TimecardTimeEntryView> _timecardTimeEntryViews;

        //Current
        private List<Date> seletedWeek = null;
        private List<Date> selectedDate = null;
        private Employee selectedEmployee = null;
        private TimecardTimeEntryView selectedTimecard = null;
        
        public TimecardTestViewModel()
        {
            InitialLoad();
            NavCommand = new RelayCommand<string>(OnClick);
        }

        private BindableBase _CurrentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public RelayCommand<string> NavCommand { get; private set; }

        private void OnClick(string executeMethod)
        {
            switch (executeMethod)
            {
                case "employeeLoad":
                    LoadEmployee();
                    break;
                default:                    
                    break;
            }
        }




        private void InitialLoad()
        {

            _dates = new ObservableCollection<Date>(_dateRepository.GetAll().Select(t => t.ToUIModel()));
            _employees = new ObservableCollection<Employee>(_employeeRepository.GetAll().Select(t => t.ToUIModel()));
            _timecards = new ObservableCollection<TimecardView>(_timecardRepository.GetAll().Select(t => t.ToUIModel()));
            //_timeEntries = new ObservableCollection<TimeEntryView>(_timeEntryViewRepository.GetAll().Select(t => t.ToUIModel()));
            _timecardTimeEntryViews = new ObservableCollection<TimecardTimeEntryView>(_timecardTimeEntryViewRepository.GetAll().Select(t => t.ToUIModel()));

        }
        

        private void LoadEmployee()
        {
            



        }
                     
        public ObservableCollection<Date> Dates
        {
            get { return _dates; }
            set { SetProperty(ref _dates, value); }
        }

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
        }

        public ObservableCollection<TimecardView> TimecardViews
        {
            get { return _timecards; }
            set { SetProperty(ref _timecards, value); }
        }

        /*
        public ObservableCollection<TimeEntryView> TimeEntryViews
        {
            get { return _timeEntries; }
            set { SetProperty(ref _timeEntries, value); }
        }
        */


        public ObservableCollection<TimecardTimeEntryView> TimecardTimeEntryViews
        {
            get { return _timecardTimeEntryViews; }
            set { SetProperty(ref _timecardTimeEntryViews, value); }
        }



    }
}

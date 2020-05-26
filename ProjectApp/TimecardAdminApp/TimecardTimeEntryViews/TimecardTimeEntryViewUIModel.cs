using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using TimecardAdminApp.Employees;
using System.Windows;

namespace TimecardAdminApp.TimecardTimeEntryViews
{
    class TimecardTimeEntryViewUIModel : BindableBase
    {

        // Repository
        private static TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryViewRepository _timecardTimeEntryViewRepository = new TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryViewRepository();

        // Data
        private Employee _selectedEmployee = null;
        private ObservableCollection<TimecardTimeEntryView> _employeeEntries;
        private ObservableCollection<TimecardTimeEntryView> _timecardTimeEntryViews;

        private TimecardTimeEntryView selectedEntry = null;

        

        public TimecardTimeEntryViewUIModel()
        {            
        }


        /// <summary>
        /// HARD CODED!!! TEMPORARY!
        /// </summary>
        /// <param name="employee"></param>
        public TimecardTimeEntryViewUIModel(Employee employee)
        {
            _selectedEmployee = employee;

            if(employee != null)
                LoadEmployeeTimecard(employee.EmployeeKey, 20200516);

            MessageBox.Show($"Loaded Employee: {SelectedEmployeeName}");
            var test = 1;

        }

        public TimecardTimeEntryViewUIModel(Employees.Employee employee,int weekEndDateKey)
        {
            LoadEmployeeTimecard(employee.EmployeeKey, weekEndDateKey);
        }



        public void LoadEmployeeTimecard(int employeeKey, int weekEndDateKey)
        {
            
            _employeeEntries = new ObservableCollection<TimecardTimeEntryView>(_timecardTimeEntryViewRepository.GetAll().Where(t => t.EmployeeKey == employeeKey && t.WeekEndDateKey == weekEndDateKey).Select(t => t.ToUIModel()));            
            
        }
        





        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value;  }
        }

        public string SelectedEmployeeName
        {
            get {
                if (_selectedEmployee != null)
                    return _selectedEmployee.EmployeeName;
                else
                    return null;
            }
        }

        public ObservableCollection<TimecardTimeEntryView> EmployeeEntries
        {
            get { return _employeeEntries; }
            set { SetProperty(ref _employeeEntries, value); }
        }








    }
}

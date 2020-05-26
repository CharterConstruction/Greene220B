using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
//using System.Collections.Generic;

//using TimecardRepository.DateViews;
//using TimecardRepository.TimecardViews;
//ing TimecardRepository.TimeEntryViews;


using TimecardAdminApp.DateViews;
using TimecardAdminApp.Employees;
using TimecardAdminApp.TimecardViews;
using TimecardAdminApp.TimeEntryViews;



namespace TimecardAdminApp.TimeEntryRows
{

    /// <summary>
    /// Per Row - So... per job, job phase, pay type, however... it it grouped by week.
    /// Instantiate with employee, week identifier, and a row...  
    /// </summary>
    public class TimeEntryRowViewModel : BindableBase
    {
        //NEED PER WEEK/EMPLOYEE VIEW MODEL
            //THEN PER ROW VIEW MODEL
        private WeekViewModel dateViewModel = new WeekViewModel();

        private static TimecardRepository.TimecardViews.TimecardViewRepository _timecardViewRepository      = new TimecardRepository.TimecardViews.TimecardViewRepository();
        private static TimecardRepository.TimeEntryViews.TimeEntryViewRepository _timeEntryViewRepository   = new TimecardRepository.TimeEntryViews.TimeEntryViewRepository();
                
        public List<DateView> _weekDates { get; set; }
        public List<DateView> WeekDates { get { return _weekDates; } }

        public Employee _employee { get; set; }
        public Employee Employee { get { return _employee; } }

        public TimecardView _rowDetails { get; set; }
        public TimecardView RowDetails { get { return _rowDetails; } }

        public List<TimeEntryView> _rowEntries { get; set; }
        public List<TimeEntryView> RowEntries { get { return RowEntries; } }

        public string   EntryGroup { get { return _rowDetails.EntryGroup; } }
        public string   RowLabel { get { return _rowDetails.RowLabel; } }
        public int      CompanyKey { get { return _rowDetails.CompanyKey; } }
        public string   PayrollDepartmentCode { get { return _rowDetails.PayrollDepartmentCode; } }
        public int      JobKey { get { return int.Parse(_rowDetails.JobKey.ToString()); } }
        public int      PhaseKey { get { return int.Parse(_rowDetails.PhaseKey.ToString()); } }
        public int      CostCenterKey { get { return int.Parse(_rowDetails.CostCenterKey.ToString()); } }        
        public int      WeekEndDateKey { get { return int.Parse(_weekDates.Where(t => t.CurrentWeekEndDateKey  == t.DateKey).FirstOrDefault().ToString()); } }

        



        public TimeEntryRowViewModel()
        {
                        
        }
        
        
        /*
            Main view model will pass employee and week..
                        Load timecard and time entries...
                        Create per-row grouped TimeEntryRowViewModels...
            
        */


        public TimeEntryRowViewModel(Employee employee, TimecardView timecardView)
        {
            _employee = employee;      
            
        }

        public void UpdateEmployee(Employee employee)
        {
            _employee = employee;
        }

        public void UpdateRowDetails(TimecardView timecardView)
        {
            _rowDetails = timecardView;            
        }


        public void LoadWeeklyTimecard()
        {
            dateViewModel.UpdateWeek("ThisWeek");

        }

           
        
     
        //add on prop change....
        public Employee SelectedEmployee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        public string SelectedEmployeeName
        {
            get
            {
                if (Employee != null)
                    return Employee.EmployeeName;
                else
                    return null;
            }
        }



    }
}







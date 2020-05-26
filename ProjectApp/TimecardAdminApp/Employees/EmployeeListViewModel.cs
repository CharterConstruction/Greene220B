using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using TimecardRepository.Employees;
using System.Windows;
using System.Windows.Data;
using System.Windows.Controls;
using System.ComponentModel;

namespace TimecardAdminApp.Employees
{
    public class EmployeeListViewModel : BindableBase
    {

        private TimecardRepository.Employees.EmployeeRepository _employeeRepository = new TimecardRepository.Employees.EmployeeRepository();

        

        public EmployeeListViewModel()
        {
            LoadEmployees();
            _employeeView = CollectionViewSource.GetDefaultView(_employees as IList<Employee>);
            _employeeView.Filter = EmployeeFilter;

            SelectEmployeeCommand = new RelayCommand<Employee>(OnEmployeeSelected);
        }


        private List<Employee> _employees = null;
        private ICollectionView _employeeView = null;
        public ICollectionView Employees
        {
            get { return _employeeView; }
        }

        private string _searchString = null;
        public string SearchString
        {
            get { return _searchString; }
            set
            {
                _searchString = value;
                OnPropertyChanged("SearchString");
                Employees.Refresh();
            }
        }

        private bool EmployeeFilter(object item)
        {
            Employee employee = item as Employee;

            return SearchString == null
                || employee.EmployeeName.Contains(_searchString);


        }




        public void LoadEmployees()
        {            
            _employees = _employeeRepository.GetAll().Select(t => t.ToUIModel()).ToList();
            //CreateEmployeeView();
        }

        public void CreateEmployeeView()
        {
            if(_employees != null)
            {
                IList<Employee> employees = _employees;
                ICollectionView cv = CollectionViewSource.GetDefaultView(employees);
                cv.Filter = EmployeeFilter;          

                _employeeView = cv;

            }
 
        }



        public RelayCommand<string> FilterEmployeesByNameCommand { get; private set; }

        public event Action<string> EmployeeSearchString = delegate { };



        // ICommand Pattern

        public RelayCommand<Employee> SelectEmployeeCommand { get; private set; }

        public event Action<Employee> EmployeeSelected = delegate { };

        private void OnEmployeeSelected(Employee employee)
        {
            //SelectedEmployee = employee;
            EmployeeSelected(employee);
        }







    }
}

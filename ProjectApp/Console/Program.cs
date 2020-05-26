using System;
using System.Collections.Generic;
using System.Text;

//using TimecardAdminApp.Employees;
//using TimecardAdminApp.Jobs;
/*
EmployeeListViewModel employeeListViewModel = new TimecardAdminApp.Employees.EmployeeListViewModel();
JobListViewModel jobListViewModel = new TimecardAdminApp.Jobs.JobListViewModel();
*/

using TimecardRepository.Jobs;
using TimecardRepository.Employees;
using TimecardRepository.ManagerEmployees;
using System.Windows;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            var jobs = new JobRepository().GetAll();
            var employees = new EmployeeRepository().GetAll();
            var managerEmployees = new ManagerEmployeeRepository().GetAll();



            MessageBox.Show(
                $"{jobs.Count} jobs" + Environment.NewLine +
                $"{employees.Count} employees" + Environment.NewLine +
                $"{managerEmployees.Count} managerEmployees" + Environment.NewLine
                );



            TimecardAdminApp.MainWindow appWindow = new TimecardAdminApp.MainWindow();

            appWindow.Show();
            appWindow.Activate();            

        }
    }
}

using ContactDB;
using System.Collections.Generic;
using System.Linq;
using TimecardRepository.Interfaces;

// This project/namespace maps to the Database Contacts
namespace TimecardRepository.Employees
{    
    /// <summary>
    /// Retreives database objects from database project and converts them into repository objects
    /// </summary>
    public class EmployeeRepository : IDataRepository<TimecardRepository.Employees.Employee>
    {
        public Employee Add(TimecardRepository.Employees.Employee newObject)
        {
            var databaseObject = newObject.ToDbModel();            

            DatabaseManager.Instance.Employee.Add(databaseObject);
            DatabaseManager.Instance.SaveChanges();

            return databaseObject.ToRepositoryModel();
        }

        public IEnumerable<Employee> Query()
        {
            return DatabaseManager.Instance.Employee.Select(t => t.ToRepositoryModel());
        }

        public List<Employee> GetAll()
        {
            return Query().ToList();
        }

        public bool Remove(Employee inputObject)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Employee inputObject)
        {
            throw new System.NotImplementedException();
        }

        /*
        public bool Remove(int id)
        {

            var items = DatabaseManager.Instance.Employee
                    .Where(t => t.EmployeeKey == id);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Employee.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        public bool Update(TimecardRepository.Models.Employee Employee)
        {
            var objectToUpdate = Employee.ToDbModel();
            var original = DatabaseManager.Instance.Employee.Find(objectToUpdate.EmployeeKey);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(objectToUpdate);
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }*/
    }
}

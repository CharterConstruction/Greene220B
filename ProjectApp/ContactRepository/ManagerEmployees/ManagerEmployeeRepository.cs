using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TimecardRepository.Interfaces;

namespace TimecardRepository.ManagerEmployees
{
        /// <summary>
        /// Retreives database objects from database project and converts them into repository objects
        /// </summary>
        public class ManagerEmployeeRepository : IDataRepository<TimecardRepository.ManagerEmployees.ManagerEmployee>
        {
            public ManagerEmployee Add(TimecardRepository.ManagerEmployees.ManagerEmployee newObject)
            {
                var databaseObject = newObject.ToDbModel();

                DatabaseManager.Instance.ManagerEmployee.Add(databaseObject);
                DatabaseManager.Instance.SaveChanges();

                return databaseObject.ToRepositoryModel();
            }

            public IEnumerable<ManagerEmployee> Query()
            {
                return DatabaseManager.Instance.ManagerEmployee.Select(t => t.ToRepositoryModel());
            }

            public List<ManagerEmployee> GetAll()
            {
                return DatabaseManager.Instance.ManagerEmployee.Select(t => t.ToRepositoryModel()).ToList();
            }
            
            public bool Remove(TimecardRepository.ManagerEmployees.ManagerEmployee ManagerEmployee)
            {
                devTimecardDB.ManagerEmployee objectToUpdate = ManagerEmployee.ToDbModel();
                var items = DatabaseManager.Instance.ManagerEmployee.Where(t => t.ManagerKey == objectToUpdate.ManagerKey && t.EmployeeKey == objectToUpdate.EmployeeKey);

            if (items.Count() == 0)
                {
                    return false;
                }

                DatabaseManager.Instance.ManagerEmployee.Remove(items.First());
                DatabaseManager.Instance.SaveChanges();

                return true;
            }

            public bool Update(TimecardRepository.ManagerEmployees.ManagerEmployee ManagerEmployee)
            {
            devTimecardDB.ManagerEmployee objectToUpdate = ManagerEmployee.ToDbModel();
            var original = DatabaseManager.Instance.ManagerEmployee.Where(t => t.ManagerKey == objectToUpdate.ManagerKey && t.EmployeeKey == objectToUpdate.EmployeeKey);

                if (original != null)
                {
                    DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(objectToUpdate);
                    DatabaseManager.Instance.SaveChanges();
                    return true;
                }

                return false;
            }

 
    }
}

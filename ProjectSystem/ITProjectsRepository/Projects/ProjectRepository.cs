using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ITPM.Database;
using Microsoft.EntityFrameworkCore.Internal;

namespace ITPM.Repository.Projects
{
  

    public class ProjectRepository : IDataRepository<Project>
    {    

        public Project Add(Project newObject)
        {
            var databaseObject = newObject.ToDbModel();

            DatabaseManager.Instance.Project.Add(databaseObject);
            DatabaseManager.Instance.SaveChanges();

            return databaseObject.ToRepositoryModel();
        }

        public bool Remove(Project inputObject)
        {
            
            var table = DatabaseManager.Instance.Project;
            var row = table.Where(t => t.ProjectKey == inputObject.ToDbModel().ProjectKey);

            if (row.Any())
            {
                DatabaseManager.Instance.Project.Remove(row.First());
                DatabaseManager.Instance.SaveChanges();

                return true; 
            }
            else
            {
                return false;
            }

        }

        public bool Update(Project inputObject)
        {
            var updated = inputObject.ToDbModel();
            var original = DatabaseManager.Instance.Project.Find(updated.ProjectKey);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(updated);
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }
               
        public IEnumerable<Project> GetAll()
        {
            return DatabaseManager.Instance.Project.Select(t => t.ToRepositoryModel()).ToList();

        }
                       
    }
}

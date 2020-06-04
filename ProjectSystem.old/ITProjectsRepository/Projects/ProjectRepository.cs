using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ITPM.Database;
using Microsoft.EntityFrameworkCore.Internal;

namespace ITPM.Repository.Projects
{
    using static ProjectRepositoryExtension;

    public class ProjectRepository : IDataRepository<Project>
    {    

        public Project Add(Project newObject)
        {
            var databaseObject = newObject.ToDbModel();
            
            //temp
            databaseObject.StageKey = 6;

            DatabaseManager.Instance.Project.Add(databaseObject);
            DatabaseManager.Instance.SaveChanges();

            return databaseObject.ToRepositoryModel();
        }

        public bool Remove(int projectIdToDelete)
        {
            
            var table = DatabaseManager.Instance.Project;
            var row = table.Where(t => t.ProjectKey == projectIdToDelete);

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



    public static class ProjectRepositoryExtension
    {
        public static void IfStageNullSetDefault(this Project project)
        {
            if(project.StageKey == 0)
            {                
                project.StageKey = 6;
            }
        }
    }

}

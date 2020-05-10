using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ITProjectsDB;
using Microsoft.EntityFrameworkCore.Internal;

namespace ITProjectsRepository
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Concept { get; set; }
        public int StageKey { get; set; }
        public int StatusKey { get; set; }     

    }

    internal static class ProjectModelConverter
    {
        //DATABASE TABLE COLUMNS
        internal static Project ToDbModel(this ProjectModel inputObject)
        {
            if (inputObject.StageKey == 0)
            {
                var defaultStage = DatabaseManager.Instance.Stage.Select(t => t).First();
                inputObject.StageKey = defaultStage.StageKey;
            }
            if (inputObject.StatusKey == 0)
            {
                var defaultStatus = DatabaseManager.Instance.Status.Select(t => t).First();
                inputObject.StatusKey = defaultStatus.StatusKey;
            }


            return new Project
            {
                ProjectKey = inputObject.Id,
                ProjectName = inputObject.Name,
                ProjectConcept = inputObject.Concept,
                StageKey = inputObject.StageKey,
                StatusKey = inputObject.StatusKey
            };
        }
    }

    public static class ProjectRepoConverter
    {
        public static ProjectModel ToProjectModel(this Project project)
        {
            return new ProjectModel
            {
                Id = project.ProjectKey,
                Name = project.ProjectName,
                Concept = project.ProjectConcept,
                StageKey = project.StageKey,
                StatusKey = project.StatusKey
            };
        }
    }



    public class ProjectRepository : IDataRepository<ProjectModel>
    {


    

        public ProjectModel Add(ProjectModel inputObject)
        {
            var newDbObject = inputObject.ToDbModel();
            DatabaseManager.Instance.Project.Add(newDbObject);
            DatabaseManager.Instance.SaveChanges();

            return new ProjectModel
            {
                Id = newDbObject.ProjectKey,
                Name = newDbObject.ProjectName,
                Concept = newDbObject.ProjectConcept,
                StageKey = newDbObject.StageKey,
                StatusKey = newDbObject.StatusKey
            };
        }

        public bool Remove(ProjectModel inputObject)
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

        public bool Update(ProjectModel inputObject)
        {
            Project updated = inputObject.ToDbModel();
            var original = DatabaseManager.Instance.Project.Find(updated.ProjectKey);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(updated);
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }
               
        public IEnumerable<ProjectModel> GetAll()
        {
            var table = DatabaseManager.Instance.Project;

            return table.Select(t => t.ToProjectModel()).ToList();

        }
                       
    }
}

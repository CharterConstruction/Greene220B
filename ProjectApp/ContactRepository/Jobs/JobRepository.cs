using ContactDB;
using System.Collections.Generic;
using System.Linq;


// This project/namespace maps to the Database Contacts
namespace TimecardRepository.Jobs
{    
    /// <summary>
    /// Retreives database objects from database project and converts them into repository objects
    /// </summary>
    public class JobRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.Jobs.Job>
    {
        public Job Add(TimecardRepository.Jobs.Job newObject)
        {
            var databaseObject = newObject.ToDbModel();

            DatabaseManager.Instance.Job.Add(databaseObject);
            DatabaseManager.Instance.SaveChanges();

            return databaseObject.ToRepositoryModel();
        }

        public IEnumerable<Job> Query()
        {
            return DatabaseManager.Instance.Job.Select(t => t.ToRepositoryModel());
        }

        public List<Job> GetAll()
        {
            return DatabaseManager.Instance.Job.Select(t => t.ToRepositoryModel()).ToList();
        }

        public bool Remove(Job inputObject)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Job inputObject)
        {
            throw new System.NotImplementedException();
        }

        /*
        public bool Remove(int id)
        {

            var items = DatabaseManager.Instance.Job
                    .Where(t => t.JobKey == id);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Job.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        public bool Update(TimecardRepository.Models.Job job)
        {
            var objectToUpdate = job.ToDbModel();
            var original = DatabaseManager.Instance.Job.Find(objectToUpdate.JobKey);

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

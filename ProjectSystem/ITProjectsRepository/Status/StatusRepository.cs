using System;
using System.Collections.Generic;
using System.Linq;


namespace ITPM.Repository.Statuses
{
    /// <summary>
    /// Retreives database objects from database project and converts them into repository objects
    /// </summary>
    public class StatusRepository : IDataRepository<ITPM.Repository.Statuses.Status>
    {
        public Status Add(ITPM.Repository.Statuses.Status newObject)
        {
            var databaseObject = newObject.ToDbModel();

            DatabaseManager.Instance.Status.Add(databaseObject);
            DatabaseManager.Instance.SaveChanges();

            return databaseObject.ToRepositoryModel();
        }

        public IEnumerable<Status> Query()
        {
            return DatabaseManager.Instance.Status.Select(t => t.ToRepositoryModel());
        }

        public IEnumerable<Status> GetAll()
        {
            return Query().ToList();
        }

        public bool Remove(Status inputObject)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Status inputObject)
        {
            throw new System.NotImplementedException();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TimecardRepository.Interfaces;

namespace TimecardRepository.JobPhases
{

    public class JobPhaseRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.JobPhases.JobPhase>
    {
        public JobPhase Add(JobPhase inputObject)
        {
            throw new NotImplementedException();
        }

        public List<JobPhase> GetAll()
        {
            return this.Query().ToList();
        }

        public IEnumerable<JobPhase> Query()
        {
            return DatabaseManager.Instance.JobPhase.Select(t => t.ToRepositoryModel());
        }

        public bool Remove(JobPhase inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(JobPhase inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TimecardRepository.Timecards;

namespace TimecardRepository.Timecards
{

    public class Timecard_Repository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.Timecards.Timecard>
    {
        public Timecard Add(Timecard inputObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Timecard> Query()
        {
            return DatabaseManager.Instance.Timecard.Select(t => t.ToRepositoryModel());
        }

        public List<Timecard> GetAll()
        {
            return this.Query().ToList();
        }

        public bool Remove(Timecard inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(Timecard inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

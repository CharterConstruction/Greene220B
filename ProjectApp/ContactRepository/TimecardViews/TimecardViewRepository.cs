using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TimecardRepository.Timecards;

namespace TimecardRepository.TimecardViews
{

    public class TimecardViewRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.TimecardViews.TimecardView>
    {
        public TimecardView Add(TimecardView inputObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimecardView> Query()
        {
            return DatabaseManager.Instance.TimecardView.Select(t => t.ToRepositoryModel());
        }

        public List<TimecardView> GetAll()
        {
            return this.Query().ToList();
        }

        public bool Remove(TimecardView inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(TimecardView inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

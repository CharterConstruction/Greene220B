using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TimecardRepository.Timecards;

namespace TimecardRepository.TimecardTimeEntryViews
{

    public class TimecardTimeEntryViewRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.TimecardTimeEntryViews.TimecardTimeEntryView>
    {
        public TimecardTimeEntryView Add(TimecardTimeEntryView inputObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimecardTimeEntryView> Query()
        {
            return DatabaseManager.Instance.TimecardTimeEntryView.Select(t => t.ToRepositoryModel());
        }

        public List<TimecardTimeEntryView> GetAll()
        {
            return this.Query().ToList();
        }

        public bool Remove(TimecardTimeEntryView inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(TimecardTimeEntryView inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

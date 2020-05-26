using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace TimecardRepository.TimeEntryViews
{

    public class TimeEntryViewRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.TimeEntryViews.TimeEntryView>
    {
        public TimeEntryView Add(TimeEntryView inputObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeEntryView> Query()
        {
            return DatabaseManager.Instance.TimeEntryView.Select(t => t.ToRepositoryModel());
        }

        public List<TimeEntryView> GetAll()
        {
            return this.Query().ToList();
        }

        public bool Remove(TimeEntryView inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(TimeEntryView inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

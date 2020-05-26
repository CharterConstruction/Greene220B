using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using TimecardRepository.Interfaces;

namespace TimecardRepository.DateViews
{

    public class DateViewRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.DateViews.DateView>
    {
        public DateView Add(TimecardRepository.DateViews.DateView newObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DateView> Query()
        {
            return DatabaseManager.Instance.DateView.Select(t => t.ToRepositoryModel());
        }

        public List<DateView> GetAll()
        {
            return DatabaseManager.Instance.DateView.Select(t => t.ToRepositoryModel()).ToList();
            //return Query().ToList();
        }

        public bool Remove(DateView inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(DateView inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

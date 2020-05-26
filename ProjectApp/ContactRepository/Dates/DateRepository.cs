using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using TimecardRepository.Interfaces;

namespace TimecardRepository.Dates
{

    public class DateRepository : TimecardRepository.Interfaces.IDataRepository<TimecardRepository.Dates.Date>
    {
        public Date Add(TimecardRepository.Dates.Date newObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Date> Query()
        {
            return DatabaseManager.Instance.Date.Select(t => t.ToRepositoryModel());
        }

        public List<Date> GetAll()
        {
            return DatabaseManager.Instance.Date.Select(t => t.ToRepositoryModel()).ToList();
            //return Query().ToList();
        }

        public bool Remove(Date inputObject)
        {
            throw new NotImplementedException();
        }

        public bool Update(Date inputObject)
        {
            throw new NotImplementedException();
        }
    }
}

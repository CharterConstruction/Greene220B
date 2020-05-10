using System;
using System.Collections.Generic;
using System.Text;

namespace ITProjectsRepository
{
    public interface IDataRepository<T>
    {

        T Add(T inputObject);

        bool Remove(T inputObject);

        bool Update(T inputObject);

        IEnumerable<T> GetAll();       

    }
}

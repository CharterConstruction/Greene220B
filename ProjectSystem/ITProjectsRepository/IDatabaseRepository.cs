using System;
using System.Collections.Generic;
using System.Text;

namespace ITPM.Repository
{
    public interface IDataRepository<T>
    {

        T Add(T inputObject);

        bool Remove(T inputObject);

        bool Update(T inputObject);

        IEnumerable<T> GetAll();      

    }
}

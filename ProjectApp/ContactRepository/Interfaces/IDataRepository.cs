using System;
using System.Collections.Generic;
using System.Text;

namespace TimecardRepository.Interfaces
{
    
    /// <summary>
    /// Enforces CRUD methods.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataRepository<T>
    {
        T Add(T inputObject);

        List<T> GetAll(); 
        
        bool Update(T inputObject);

        bool Remove(T inputObject);
        
        IEnumerable<T> Query();

    }
}

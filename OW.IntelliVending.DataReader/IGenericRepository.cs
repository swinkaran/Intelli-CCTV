using System;
using System.Collections.Generic;

namespace OW.IntelliVending.DataReader
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}

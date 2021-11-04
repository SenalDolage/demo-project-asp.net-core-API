using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> FindAll();
    }
}

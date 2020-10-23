using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce.DataAccess.Abstract
{
    public interface IQueryableRepository<T> where T:class
    {
        IQueryable<T> GetAll { get; }
    }
}

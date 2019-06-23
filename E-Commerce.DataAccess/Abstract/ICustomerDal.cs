using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Repository;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}

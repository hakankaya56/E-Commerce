using Core.Repository;
using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}

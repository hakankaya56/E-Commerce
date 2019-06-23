using System;
using System.Collections.Generic;
using System.Text;
using Core.Repository;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete.Contexts;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.DataAccess.Concrete.EntityFramework
{
     public class EfOrderDetailDal:EfEntityRepositoryBase<OrderDetail,NorthwindContext>,IOrderDetailDal
    {
    }
}

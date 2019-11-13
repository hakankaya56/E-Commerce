using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Repository;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete.Contexts;
using E_Commerce.Entities.ComplexType;
using E_Commerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {


        public List<ProductDetail> ProductList()
        {
            throw new NotImplementedException();
        }
    }
}

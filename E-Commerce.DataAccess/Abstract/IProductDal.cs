using System;
using System.Collections.Generic;
using System.Text;
using Core.Repository;
using E_Commerce.Entities.ComplexType;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> ProductList();
    }
}

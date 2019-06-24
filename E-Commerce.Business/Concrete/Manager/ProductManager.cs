using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Concrete.Manager
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> ProductList()
        {
            return _productDal.GetList();
        }
    }
}

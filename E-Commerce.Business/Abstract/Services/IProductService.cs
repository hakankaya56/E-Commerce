using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract.Services
{
    public interface IProductService
    {
        List<Product> ProductList();
    }
}

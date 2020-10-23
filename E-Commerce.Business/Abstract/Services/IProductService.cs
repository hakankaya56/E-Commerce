using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Business.Concrete.AutoMapper.Dtos.Product;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract.Services
{
    public interface IProductService
    {
        Task<List<ProductListForDto>> GetProductList();
        List<Product> GetByCategory(int categoryId);
        Product GetById(int id);
  
    }
}

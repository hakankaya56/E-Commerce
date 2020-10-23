using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.Business.Concrete.AutoMapper.Dtos.Product;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Concrete.Manager
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IQueryableRepository<Product> _productQueryable;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productDal, IQueryableRepository<Product> productQueryable, IMapper mapper)
        {
            _productDal = productDal;
            _productQueryable = productQueryable;
            _mapper = mapper;
        }


        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryID == categoryId);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductID == id);
        }

    
       public async Task<List<ProductListForDto>> GetProductList()
        {
            var productList = await _productQueryable.GetAll.Include(p => p.Category).ToListAsync();
            var productListDto = _mapper.Map<List<ProductListForDto>>(productList);
            return productListDto;
        }
    }
}

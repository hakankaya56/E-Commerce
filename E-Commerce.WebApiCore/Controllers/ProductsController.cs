using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult Products(int categoryId)
        {
            var products = _productService.ProductList(categoryId);
            return Ok(products);
        }

        [HttpGet]
        [Route("Categories")]
        public ActionResult Categories()
        {
            var categories = _categoryService.CategoryList();
            return Ok(categories);
        }
    }
}
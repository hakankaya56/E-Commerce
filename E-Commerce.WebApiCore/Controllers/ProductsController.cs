using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;


        public ProductsController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        [HttpGet]
        [Route("ProductList")]
        public async Task<IActionResult> ProductsList()
        {
            var products = await _productService.GetProductList();
            return Ok(products);
        }

        //[HttpGet]
        //[Route("detail")]
        //public ActionResult ProductDetail(int productId)
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    var productDetail = _productService.GetById(productId);
        //    stopwatch.Stop();
        //    var executionTime = string.Format("Geçen süre {0}", stopwatch.Elapsed);
        //    executionTime.ToString();
        //    return Ok(productDetail);
        //}

        [HttpGet]
        [Route("categories")]
        public ActionResult Categories()
        {
            var categories = _categoryService.CategoryList();
            return Ok(categories);
        }

        [HttpGet]
        [Route("GetByCategory")]
        public ActionResult GetByCategory(int categoryId)
        {
            var productByCategory = _productService.GetByCategory(categoryId);
            return Ok(productByCategory);
        }
    }
}
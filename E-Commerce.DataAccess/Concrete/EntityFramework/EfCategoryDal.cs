using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Repository;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete.Contexts;
using E_Commerce.Entities.ComplexType;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        public List<CategoryProducts> GetCategoryList()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var categories = from category in context.Categories
                                 join product in context.Products on category.CategoryID equals product.CategoryID
                                 group category by new { category.CategoryID, category.CategoryName }
                                 into cat

                                 select new CategoryProducts
                                 {
                                     Id = cat.Key.CategoryID,
                                     Name = cat.Key.CategoryName,
                                    
                                 };
                return categories.OrderByDescending(c=>c.Id).ToList();
            }

        }


      
    }
}

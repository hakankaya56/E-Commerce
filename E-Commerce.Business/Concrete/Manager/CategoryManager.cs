using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.Entities.ComplexType;

namespace E_Commerce.Business.Concrete.Manager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<CategoryProducts> CategoryList()
        {
            return _categoryDal.GetCategoryList();
        }
    }
}

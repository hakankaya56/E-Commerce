using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Business.Abstract.Services;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.Entities.ComplexType;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Concrete.Manager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> CategoryList()
        {
            return _categoryDal.GetList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Entities.ComplexType;
using E_Commerce.Entities.Concrete;

namespace E_Commerce.Business.Abstract.Services
{
    public interface ICategoryService
    {
        List<Category> CategoryList();
    }
}

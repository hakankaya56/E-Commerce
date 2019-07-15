using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Entities.ComplexType;

namespace E_Commerce.Business.Abstract.Services
{
    public interface ICategoryService
    {
        List<CategoryProducts> CategoryList();
    }
}

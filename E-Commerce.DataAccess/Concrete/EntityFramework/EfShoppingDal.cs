﻿using Core.Repository;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete.Contexts;
using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.DataAccess.Concrete.EntityFramework
{
     public class EfShoppingDal:EfEntityRepositoryBase<ShoppingCart, NorthwindContext>, IShoppingCartDal
    {
    }
}

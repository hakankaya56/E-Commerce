using E_Commerce.Business.Abstract.Services;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Business.Concrete.Manager
{
    public class ShoppingCartManager : IShoppingCartService
    {
        private readonly IShoppingCartDal _shoppingCartDal;
        public ShoppingCartManager(IShoppingCartDal shoppingCartDal)
        {
            _shoppingCartDal = shoppingCartDal;
        }
        public void AddCart(int productId)
        {
            var shoppingCart = _shoppingCartDal.Get(s => s.ProductID == productId);
            if(shoppingCart == null)
            {
                var cart = new ShoppingCart
                {
                    ProductID = productId,
                    CreatedDate = DateTime.Now,
                    Quantity = 1
                };
                _shoppingCartDal.Add(cart);
            }
            else
            {
                shoppingCart.Quantity += 1;
                _shoppingCartDal.Update(shoppingCart);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Business.Concrete.AutoMapper.Dtos.Product
{
   public class ProductListForDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}

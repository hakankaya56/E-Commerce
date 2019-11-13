using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Entities.ComplexType
{
     public class ProductDetail
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int CategoryName { get; set; }

        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}

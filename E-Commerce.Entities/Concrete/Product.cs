﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace E_Commerce.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }


        public virtual Category  Categories { get; set; }

    }
}

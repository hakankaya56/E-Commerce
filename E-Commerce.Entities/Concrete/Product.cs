using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace E_Commerce.Entities.Concrete
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }

    }
}

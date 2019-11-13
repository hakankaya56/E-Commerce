using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace E_Commerce.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}

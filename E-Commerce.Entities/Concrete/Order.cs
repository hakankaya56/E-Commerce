using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace E_Commerce.Entities.Concrete
{
     public class Order:IEntity
    {
        
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }


    }
}

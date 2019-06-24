using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace E_Commerce.Entities.Concrete
{
      public class OrderDetail:IEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 Qunantity { get; set; }


    }
}

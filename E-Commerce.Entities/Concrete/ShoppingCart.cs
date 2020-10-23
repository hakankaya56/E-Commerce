using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce.Entities.Concrete
{
    [Table("ShoppingCart")]
    public class ShoppingCart:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public short Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public DateTime CreatedDate{ get; set; }

    }
}

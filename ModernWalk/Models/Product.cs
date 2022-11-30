using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ModernWalk.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        public string Description { get; set; }

        public bool isAvailable { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
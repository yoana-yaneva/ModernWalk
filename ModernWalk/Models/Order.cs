using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernWalk.Models
{
    public enum TypeDelivery
    {
        //U - ultimate delivery
        //E - Express Delivery
        //R - Regular delivery
        U, E, R
    }

    public enum Discount
    {
        //F - 5%
        //T - 10%
        //FT - 15%
        F, T, FT
    }
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public TypeDelivery? TypeDelivery { get; set; }

        public Discount? Discount { get; set; }


        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
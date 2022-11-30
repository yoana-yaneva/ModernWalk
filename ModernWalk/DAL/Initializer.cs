using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ModernWalk.Models;

namespace ModernWalk.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var users = new List<User>
            {
                new User{FirstName="Carson", LastName="Alexander", Email="carson.alexander@gmail.com", OrderDate=DateTime.ParseExact("2005-09-01","yyyy-MM-dd",null), Gender='M'},
                //new User{FirstName="Laura", LastName="Norman", Email="laurs.norm@gmail.com", OrderDate=DateTime.ParseExact("2005-09-01","yyyy-MM-dd",null), Gender='F' },
                //new User{FirstName="Meredith", LastName="Alonso", Email="alonso@gmail.com", OrderDate=DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null), Gender='F' },
                //new User{FirstName="Justin", LastName="Crugg", Email="cruggy@gmail.com", OrderDate=DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null), Gender='M' },
                //new User{FirstName="Nino", LastName="Smith", Email="smitnn.norm@gmail.com", OrderDate=DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null), Gender='M' }
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{ProductID=1001, Description="Sweather", Price=49.99M, isAvailable=true },
                new Product{ProductID=1002, Description="Pants", Price=19.99M, isAvailable=true },
                new Product{ProductID=1003, Description="Jeans", Price=29.99M, isAvailable=true },
                new Product{ProductID=1004, Description="TShirt", Price=39.99M, isAvailable=true },
                new Product{ProductID=1005, Description="Vest", Price=59.99M, isAvailable=true }
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{UserID=1, ProductID=1004, TypeDelivery=TypeDelivery.R, Discount=Discount.FT},
                new Order{UserID=2, ProductID=1003, TypeDelivery=TypeDelivery.E},
                new Order{UserID=3, ProductID=1001, Discount=Discount.F},
                new Order{UserID=3, ProductID=1002, TypeDelivery=TypeDelivery.U, Discount=Discount.F},
                new Order{UserID=5, ProductID=1003, TypeDelivery=TypeDelivery.E},
            };

            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();

        }
    }
}
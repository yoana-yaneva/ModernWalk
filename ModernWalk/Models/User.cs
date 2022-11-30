using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModernWalk.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime OrderDate { get; set; }

        public string Email { get; set; }
        public char Gender { get; set; }
        

        public virtual ICollection<Order> Orders { get; set; }
    }
}
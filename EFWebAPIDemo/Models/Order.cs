using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFWebAPIDemo.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation to enable to navigate to the order details 
        //of a particular order
        //virtual is use for navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
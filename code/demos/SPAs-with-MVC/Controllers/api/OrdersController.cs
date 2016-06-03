using SPAs_with_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SPAs_with_MVC.Controllers.api
{
    [RoutePrefix("orders")]
    public class OrdersController : BaseApiController
    {
        [HttpGet]
        public List<Order> Get()
        {
            var orders = new List<Order>
		    {
		        new Order() { OrderId = 1, ItemDescription = "Item 1", ItemPrice = 1.24m, ItemQuantity = 2, FullPrice = 2.48M, OrderDate = DateTime.Now },
		        new Order() { OrderId = 2, ItemDescription = "Item 2", ItemPrice = 1.24m, ItemQuantity = 2, FullPrice = 2.48M, OrderDate = DateTime.Now },
		        new Order() { OrderId = 3, ItemDescription = "Item 3", ItemPrice = 1.24m, ItemQuantity = 2, FullPrice = 2.48M, OrderDate = DateTime.Now },
		        new Order() { OrderId = 4, ItemDescription = "Item 4", ItemPrice = 1.24m, ItemQuantity = 2, FullPrice = 2.48M, OrderDate = DateTime.Now },
		        new Order() { OrderId = 5, ItemDescription = "Item 5", ItemPrice = 1.24m, ItemQuantity = 2, FullPrice = 2.48M, OrderDate = DateTime.Now }
		    };

            return orders;
        }

        [HttpPost]
        public Order Save(Order order)
        {
            order.OrderId = 1;
            return order;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAs_with_MVC.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public string ItemDescription { get; set; }
		public int ItemQuantity { get; set; }
		public decimal ItemPrice { get; set; }
		public decimal FullPrice { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
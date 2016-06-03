using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPAs_with_MVC.Models
{
	public class Context : DbContext
	{
		public System.Data.Entity.DbSet<SPAs_with_MVC.Models.Contact> Contacts { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAs_with_MVC.Controllers
{
    public class HtmlViewsController : Controller
    {
        public ActionResult Orders()
        {
            return PartialView();
        }

		public ActionResult Home()
		{
			return PartialView();
		}

		public ActionResult Login()
		{
			return PartialView();
		}

		public ActionResult Logout()
		{
			return new EmptyResult();
		}
    }
}
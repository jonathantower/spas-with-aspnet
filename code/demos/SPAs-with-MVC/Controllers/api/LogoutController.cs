using SPAs_with_MVC.Models;
using SPAs_with_MVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.Results;
using System.Web.Security;

namespace SPAs_with_MVC.Controllers.api
{
	[AllowAnonymous]
	[RoutePrefix("logout")]
	public class LogoutController : BaseApiController
	{
		[HttpGet]
		public HttpResponseMessage Logout()
		{
			FormsAuthentication.SignOut();
			return Request.CreateResponse(HttpStatusCode.OK); //HTTP.200
		}

	}
}

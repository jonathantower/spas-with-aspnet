using SPAs_with_MVC.Models;
using SPAs_with_MVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
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
	[RoutePrefix("login")]
	public class LoginController : BaseApiController
	{
		[HttpPost]
		public HttpResponseMessage Login(LoginViewModel data)
		{
            if (ConfigurationManager.AppSettings["AllowLogin"].ToLower() != "true") 
                return Request.CreateResponse(HttpStatusCode.BadRequest);

			if (ModelState.IsValid)
			{
				FormsAuthentication.SetAuthCookie(data.Username, false);
				return Request.CreateResponse(HttpStatusCode.OK); //HTTP.200	
			}

			return Request.CreateResponse(HttpStatusCode.BadRequest, GetErrorList()); //HTTP.400	
		}

	}
}

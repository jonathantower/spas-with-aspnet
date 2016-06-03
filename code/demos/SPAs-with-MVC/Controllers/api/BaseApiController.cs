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

namespace SPAs_with_MVC.Controllers.api
{
	[Authorize]
	public class BaseApiController : ApiController
	{
        protected ExpandoObject GetErrorList()
		{
			dynamic errorList = new ExpandoObject();
			var p = errorList as IDictionary<String, object>;
			foreach (var key in ModelState.Keys)
			{
				ModelState modelState = null;
				if (ModelState.TryGetValue(key, out modelState))
				{
					foreach (var error in modelState.Errors)
					{
						p[key.Replace("data.", "")] = error.ErrorMessage;
					}
				}
			}
			return (ExpandoObject)errorList;
		}

	}
}

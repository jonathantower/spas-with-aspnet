using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SPAs_with_MVC.Models.ViewModels
{
	public class LoginViewModel
	{
		[Required]
		public string Username { get; set; }

		[Required]
		//[MinLength(8, ErrorMessage = "{0} must be at least {1} characters")]
		public string Password { get; set; }
	}
}
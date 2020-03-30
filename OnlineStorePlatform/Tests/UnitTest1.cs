using System;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineStorePlatform.Models;

namespace Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Testlogin()
		{
			OnlineStorePlatform.Controllers.UserController userController= new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = userController.login("hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;
			
			Assert.AreEqual(contentResult.Content.username.ToString(), "Hussien");
			Assert.AreEqual(contentResult.Content.password.ToString(), "12345678");
		}
	}
}

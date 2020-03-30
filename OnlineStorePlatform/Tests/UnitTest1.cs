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
		public void Testlogin1()
		{
			OnlineStorePlatform.Controllers.UserController test1 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = test1.login("Hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;
			Assert.AreEqual(contentResult.Content.username.ToString(), "Hussien");
			Assert.AreEqual(contentResult.Content.password.ToString(), "12345678");
		}
		[TestMethod]
		public void Testlogin2()
		{
			OnlineStorePlatform.Controllers.UserController test2 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result2 = test2.login("Hussien", "123456789");
			var contentResult2 = result2 as OkNegotiatedContentResult<string>;
			Assert.AreEqual(contentResult2.Content.ToString(), "Login Failed!");
		}
		[TestMethod]
		public void Testlogin3()
		{
			OnlineStorePlatform.Controllers.UserController test3 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result3 = test3.login("WrongUserName", "anypassword");
			var contentResult3 = result3 as OkNegotiatedContentResult<string>;
			Assert.AreEqual(contentResult3.Content.ToString(), "Login Failed!");
			
		}
	}
}

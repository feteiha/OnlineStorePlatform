using System;
using System.Collections.Generic;
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
		public void Testlogin1() //Correct credetentials
		{
			OnlineStorePlatform.Controllers.UserController test1 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = test1.login("Hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;
			Assert.AreEqual(contentResult.Content.username.ToString(), "Hussien");
			Assert.AreEqual(contentResult.Content.password.ToString(), "12345678");
		}
		[TestMethod]
		public void Testlogin2() //Wrong password
		{
			OnlineStorePlatform.Controllers.UserController test2 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result2 = test2.login("Hussien", "123456789");
			var contentResult2 = result2 as OkNegotiatedContentResult<string>;
			Assert.AreEqual(contentResult2.Content.ToString(), "Login Failed!");
		}
		[TestMethod]
		public void Testlogin3() //Wrong Username
		{
			OnlineStorePlatform.Controllers.UserController test3 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result3 = test3.login("WrongUserName", "anypassword");
			var contentResult3 = result3 as OkNegotiatedContentResult<string>;
			Assert.AreEqual(contentResult3.Content.ToString(), "Login Failed!");

		}
		[TestMethod]
		public void Testlogin4() //Ignore Case in Username
		{
			OnlineStorePlatform.Controllers.UserController test4 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result4 = test4.login("HUSSIEN", "12345678");
			var contentResult4 = result4 as OkNegotiatedContentResult<User>;

			Assert.AreEqual(contentResult4.Content.username.ToString().ToLower(), "hussien");
			Assert.AreEqual(contentResult4.Content.password.ToString(), "12345678");

		}
		[TestMethod]
		public void Testlogin5() //Case Sensitive in correct password
		{
			OnlineStorePlatform.Controllers.UserController test5 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result5 = test5.login("aho", "testSensetivity");
			var contentResult5 = result5 as OkNegotiatedContentResult<User>;

			Assert.AreEqual(contentResult5.Content.username.ToString().ToLower(), "aho");
			Assert.AreEqual(contentResult5.Content.password.ToString(), "testSensetivity");

		}
		[TestMethod]
		public void Testlogin6() //Case Sensitive in wrong password
		{
			OnlineStorePlatform.Controllers.UserController test6 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result6 = test6.login("aho", "testsensetivity");
			var contentResult6 = result6 as OkNegotiatedContentResult<string>;
			Assert.AreEqual(contentResult6.Content.ToString(), "Login Failed!");
		}

	}
        [TestMethod] // valid test case
        public void Testshowall_1()
        {
            OnlineStorePlatform.Controllers.UserController test = new OnlineStorePlatform.Controllers.UserController();
            IHttpActionResult result = test.showAll("khaled", "12345678");
            var contentResult = result as OkNegotiatedContentResult<List<User>>;
            Assert.AreNotEqual(contentResult.Content.Count, 0);
        }

        [TestMethod] // Not valid (wrong password)
        public void Testshowall_2()
        {
            OnlineStorePlatform.Controllers.UserController test = new OnlineStorePlatform.Controllers.UserController();
            IHttpActionResult result = test.showAll("khaled", "123");
            var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error! Login Failed!");
        }
        [TestMethod] // Not valid (normalUser)
        public void Testshowall_3()
        {
            OnlineStorePlatform.Controllers.UserController test = new OnlineStorePlatform.Controllers.UserController();
            IHttpActionResult result = test.showAll("normal", "12345678");
            var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error! No admin is detected!");
        }
    }
}

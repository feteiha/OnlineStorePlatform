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
<<<<<<< HEAD
		/*
		public void Testlogin()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = userController.login("hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;

=======
		public void Testlogin1() //Correct credetentials
		{
			OnlineStorePlatform.Controllers.UserController test1 = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = test1.login("Hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;
>>>>>>> 905f00978fcc9c0b14088817cf1fcc0ff2fb5b15
			Assert.AreEqual(contentResult.Content.username.ToString(), "Hussien");
			Assert.AreEqual(contentResult.Content.password.ToString(), "12345678");

		}
<<<<<<< HEAD
		*/
/*		public void Test1registerNormal()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			NormalUser u3 = new NormalUser();
			u3.username = "Anaaaaaaaaaaaa";
			u3.email = "anaaaaaaaa@yahoo.com";
			u3.password = "123456789";
			u3.fullname = "AnaaaHatem";
			u3.age = 17;
			u3.gender = "male";

			IHttpActionResult registerNormalResult3 = userController.registerNormal(u3);
			var contentResult3 = registerNormalResult3 as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult3.Content, false);

		}*/
		/*public void Test2registerNormal()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			NormalUser u = new NormalUser();
			u.username = "Anaaaaaaaaaaaaaaaaaaa";
			u.email = "anaaa@yahoo.com";
			u.password = "123456789";
			u.fullname = "AnaaaHatem";
			u.age = 18;
			u.gender = "male";

			IHttpActionResult registerNormalResult = userController.registerNormal(u);
			var contentResult = registerNormalResult as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult.Content, true);
		}*/
		/*public void Test3registerNormal()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			NormalUser u2 = new NormalUser();
			u2.username = "Anaaaa";
			u2.email = "anaaa@yahoo.com";
			u2.password = "123456789";
			u2.fullname = "AnaaaHatem";
			u2.age = 18;
			u2.gender = "male";

			IHttpActionResult registerNormalResult2 = userController.registerNormal(u2);
			var contentResult2 = registerNormalResult2 as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult2.Content, false);
		}*/
		/*
		public void Test4registerStoreOwner()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			StoreOwner s1 = new StoreOwner();
			s1.username = "StoreOwner1";
			s1.email = "StoreOwner1@yahoo.com";
			s1.password = "123456789";
			s1.fullname = "StoreOwner";
			s1.age = 18;
			s1.gender = "male";

			IHttpActionResult registerStoreOwnerResult1 = userController.registerStoreOwner(s1);
			var contentResult2 = registerStoreOwnerResult1 as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult2.Content, true);
		}
		*/
		/*
		public void Test5registerStoreOwner()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			StoreOwner s1 = new StoreOwner();
			s1.username = "StoreOwner1";
			s1.email = "StoreOwner1@yahoo.com";
			s1.password = "123456789";
			s1.fullname = "StoreOwner";
			s1.age = 18;
			s1.gender = "male";

			IHttpActionResult registerStoreOwnerResult1 = userController.registerStoreOwner(s1);
			var contentResult2 = registerStoreOwnerResult1 as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult2.Content, false);
		}*/
		/*
		public void Test6registerStoreOwner()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			StoreOwner s1 = new StoreOwner();
			s1.username = "StoreOwner2";
			s1.email = "StoreOwner1@yahoo.com";
			s1.password = "1234567";
			s1.fullname = "StoreOwner2";
			s1.age = 18;
			s1.gender = "male";

			IHttpActionResult registerStoreOwnerResult1 = userController.registerStoreOwner(s1);
			var contentResult2 = registerStoreOwnerResult1 as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult2.Content, false);
		}
		*/
		public void Test7registerStoreOwner()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

			StoreOwner s1 = new StoreOwner();
			s1.username = "StoreOwner2";
			s1.email = "StoreOwner1@yahoo.com";
			s1.password = "123456789";
			s1.fullname = "StoreOwner";
			s1.age = 15;
			s1.gender = "male";

			IHttpActionResult registerStoreOwnerResult1 = userController.registerStoreOwner(s1);
			var contentResult2 = registerStoreOwnerResult1 as OkNegotiatedContentResult<bool>;

			Assert.AreEqual(contentResult2.Content, false);
		}



	}
=======
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
>>>>>>> 905f00978fcc9c0b14088817cf1fcc0ff2fb5b15
}

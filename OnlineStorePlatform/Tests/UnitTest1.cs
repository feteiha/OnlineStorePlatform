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
		/*
		public void Testlogin()
		{
			OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = userController.login("hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;

			Assert.AreEqual(contentResult.Content.username.ToString(), "Hussien");
			Assert.AreEqual(contentResult.Content.password.ToString(), "12345678");

		}
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
}

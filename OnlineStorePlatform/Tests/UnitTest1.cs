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
	/// <summary>
	///Register Users Tests -----------------------------------------------------------------------------------------------------------------------
	/// </summary>

		[TestMethod]
		public void Test1registerNormal()
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

		}
		[TestMethod]
		public void Test2registerNormal()
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
		}
		[TestMethod]
		public void Test3registerNormal()
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
		}
		[TestMethod]
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
		[TestMethod]
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
		}
		[TestMethod]
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
		[TestMethod]
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
	/// <summary>
	///ADD ADMIN TESTS -----------------------------------------------------------------------------------------------------------------------
	/// </summary>
        [TestMethod]
        public void addAdmin_Test1()
        {
            string prefix = "addAdminTest_"; 
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // Admin not in system try to add new admin
            Adminstrator newAdmin = SetAdmin(prefix + "user1", "m1@yahoo.com");
            IHttpActionResult result = userController.addAdmin(prefix + "admin1", "addAdminTest_12345678", newAdmin);
            var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error! Login Failed!");
        }

        [TestMethod]
        public void addAdmin_Test2()
        {
            string prefix = "addAdminTest_";
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // admin in system try to add admin in system
            Adminstrator newAdmin = SetAdmin(prefix + "user2", "m2@yahoo.com");
            IHttpActionResult result = userController.addAdmin(prefix + "master", "addAdminTest_12345678", newAdmin);

			var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Adminstrator created successfully!");
        }

        [TestMethod]
        public void addAdmin_Test3()
        {
            string prefix = "addAdminTest_";
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // User in system try to add Admin in system
            Adminstrator newAdmin = SetAdmin(prefix + "user3" , "m3@yahoo.com");
            NormalUser user2 = setNormalUser(prefix + "user4" , "m4@yahoo.com");
            userController.registerNormal(user2);

            IHttpActionResult result = userController.addAdmin(prefix + "user4", "addAdminTest_12345678", newAdmin);

			var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error! No admin is detected!");
        }

        [TestMethod]
        public void addAdmin_Test4()
        {
            string prefix = "addAdminTest_";
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // Admin in system try to add admin in system
            Adminstrator newAdmin = SetAdmin(prefix + "master", "master@yahoo.com");
            IHttpActionResult result = userController.addAdmin(prefix + "master", "addAdminTest_12345678", newAdmin);

			var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error creating admin!");
        }

        [TestMethod]
        public void addAdmin_Test5()
        {
            string prefix = "addAdminTest_";
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // Admin in system try to add admin in system
            // both new admin have the same email
            Adminstrator newAdmin1 = SetAdmin(prefix + "user5", "m5@yahoo.com");
            Adminstrator newAdmin2 = SetAdmin(prefix + "user6", "m5@yahoo.com");
            IHttpActionResult result = userController.addAdmin(prefix + "master", "addAdminTest_12345678", newAdmin1);

			var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Adminstrator created successfully!");

            result = userController.addAdmin(prefix + "master", "addAdminTest_12345678", newAdmin2);

			contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error creating admin!");
        }

        [TestMethod]
        public void addAdmin_Test6()
        {
            string prefix = "addAdminTest_";
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // Admin in system try to add admin in system
            // both new admin have the user name email
            Adminstrator newAdmin1 = SetAdmin(prefix + "user8", "m8@yahoo.com");
            Adminstrator newAdmin2 = SetAdmin(prefix + "user8", "m9@yahoo.com");
            IHttpActionResult result = userController.addAdmin(prefix + "master", "addAdminTest_12345678", newAdmin1);

			var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Adminstrator created successfully!");

            result = userController.addAdmin(prefix + "master", "addAdminTest_12345678", newAdmin2);

			contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error creating admin!");
        }


	/// <summary>
	///Login Tests -----------------------------------------------------------------------------------------------------------------------
	/// </summary>

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

	/// <summary>
	///Functions used to ease testing -----------------------------------------------------------------------------------------------------------------------
	/// </summary>

		private Adminstrator SetAdmin(String userName, String email)
		{
			Adminstrator admin = new Adminstrator();
			admin.fullname = "addAdminTest_FullName";
			admin.username = userName;
			admin.email = email;
			admin.password = "addAdminTest_12345678";
			admin.gender = "male";
			admin.age = 29;
			return admin;
		}
		private NormalUser setNormalUser(String userName, String email)
		{
			NormalUser normalUser = new NormalUser();
			normalUser.fullname = "addAdminTest_FullName";
			normalUser.username = userName;
			normalUser.email = email;
			normalUser.password = "addAdminTest_12345678";
			normalUser.gender = "male";
			normalUser.age = 29;
			return normalUser;
		}

	}

}

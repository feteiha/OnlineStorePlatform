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
        private static string addAdminPassword = "addAdminTest_12345678";

		[TestMethod]
		public void Testlogin()
		{
			OnlineStorePlatform.Controllers.UserController userController= new OnlineStorePlatform.Controllers.UserController();
			IHttpActionResult result = userController.login("hussien", "12345678");
			var contentResult = result as OkNegotiatedContentResult<User>;
			
			Assert.AreEqual(contentResult.Content.username.ToString(), "Hussien");
			Assert.AreEqual(contentResult.Content.password.ToString(), "12345678");
		}

        private Adminstrator SetAdmin(String userName, String email)
        {
            Adminstrator admin = new Adminstrator();
            admin.fullname = "addAdminTest_FullName";
            admin.username = userName;
            admin.email    = email;
            admin.password = addAdminPassword;
            admin.gender   = "male";
            admin.age      = 29;
            return admin;
        }
        private NormalUser setNormalUser(String userName, String email)
        {
            NormalUser normalUser = new NormalUser();
            normalUser.fullname = "addAdminTest_FullName";
            normalUser.username = userName;
            normalUser.email = email;
            normalUser.password = addAdminPassword;
            normalUser.gender = "male";
            normalUser.age = 29;
            return normalUser;
        }

        [TestMethod]
        public void addAdmin_Test1()
        {
            string prefix = "addAdminTest_"; 
            OnlineStorePlatform.Controllers.UserController userController = new OnlineStorePlatform.Controllers.UserController();

            // Admin not in system try to add new admin
            Adminstrator newAdmin = SetAdmin(prefix + "user1", "m1@yahoo.com");
            IHttpActionResult result = userController.addAdmin(prefix + "admin1", addAdminPassword, newAdmin);
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
            IHttpActionResult result = userController.addAdmin(prefix + "master", addAdminPassword, newAdmin);
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

            IHttpActionResult result = userController.addAdmin(prefix + "user4", addAdminPassword, newAdmin);
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
            IHttpActionResult result = userController.addAdmin(prefix + "master", addAdminPassword, newAdmin);
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
            IHttpActionResult result = userController.addAdmin(prefix + "master", addAdminPassword, newAdmin1);
            var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Adminstrator created successfully!");

            result = userController.addAdmin(prefix + "master", addAdminPassword, newAdmin2);
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
            IHttpActionResult result = userController.addAdmin(prefix + "master", addAdminPassword, newAdmin1);
            var contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Adminstrator created successfully!");

            result = userController.addAdmin(prefix + "master", addAdminPassword, newAdmin2);
            contentResult = result as OkNegotiatedContentResult<string>;
            Assert.AreEqual(contentResult.Content.ToString(), "Error creating admin!");
        }
    }
}

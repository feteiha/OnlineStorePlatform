using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace OnlineStorePlatform.Controllers
{
	public class UserController : ApiController
	{
        [Route("login/")]
		[HttpPost]
		public IHttpActionResult login(string identifier, string password)
		{
			User user = Models.User.login(identifier, password);
			if (user == null)
			{
				return Ok("Login Failed!");
			}
			return Ok(content: user);
		}

		[Route("registerNormal/")]
		[HttpPost]
		public IHttpActionResult registerNormal(User user)
        {
			User toRegister = new NormalUser(user);
			bool status = ((NormalUser)toRegister).register();
            return Ok(status);
        }

		[Route("registerStoreOwner/")]
		[HttpPost]
		public IHttpActionResult registerStoreOwner(User user)
        {
			User toRegister = new StoreOwner(user);
			bool status = ((StoreOwner)toRegister).register();
			return Ok(status);
		}

		[Route("showall/")]
		[HttpPost]
		public IHttpActionResult showAll(string identifier, string password)
        {

			User loggedin = Models.User.login(identifier, password);
			if (loggedin == null)
			{
				return Ok("Error! Login Failed!");
			}
			if (loggedin.GetType().Name == "Adminstrator")
			{
				return Ok(((Adminstrator)loggedin).showAllUsers());
			}
			else
			{
				return Ok("Error! No admin is detected!");
			}
        }

		/*
		[Route("showallUsers/")]
		[HttpGet]
		public IHttpActionResult showAllUsers()
		{
			return Ok("ALL");
			//return Ok(User.showAllUsers());
		}
		*/

		[Route("addadmin/")]
		[HttpPost]
		public IHttpActionResult addAdmin(string identifier, string password, User user)
        {
			User loggedin = Models.User.login(identifier, password);
			if (loggedin == null)
			{
				return Ok("Error! Login Failed!");
			}
			if (loggedin.GetType().Name == "Adminstrator")
			{
				bool status = ((Adminstrator)loggedin).addAdminstrator(user);
				if (status)
					return Ok("Adminstrator created successfully!");
				else
					return Ok("Error creating admin!");
			}
			else
			{
				return Ok("Error! No admin is detected!");
			}
		}
    }
}

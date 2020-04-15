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
			return Ok(user);
		}

		[Route("registerNormal/")]
		[HttpPost]
        public IHttpActionResult registerNormal(NormalUser user)
        {
			bool status = user.register();
            return Ok(status);
        }

		[Route("registerStoreOwner/")]
		[HttpPost]
		public IHttpActionResult registerStoreOwner(StoreOwner user)
        {
			bool status = user.register();
			return Ok(status);
		}

		[Route("showall/")]
		[HttpGet]
        [Authentication(new string[] { "Adminstrator" }, false)]
        public IHttpActionResult showAll()
        {
            return Ok(Adminstrator.showAllUsers());
        }
		[Route("addadmin/")]
		[HttpPost]
        [Authentication(new string[] { "adminstrator" }, false)]
        public IHttpActionResult addAdmin(Adminstrator user)
        {
			bool status = Adminstrator.addAdminstrator(user);
            if (status)
                return Ok("Adminstrator created successfully!");
            else
                return Ok("Error creating admin!");
        }
    }
}

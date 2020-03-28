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
		public IHttpActionResult login (string identifier, string password)
        {
            return null;
        }
        public IHttpActionResult registerNormal()
        {
            return null;
        }
        public IHttpActionResult registerStoreOwner()
        {
            return null;
        }
        public IHttpActionResult showAllUsers()
        {
            return null;
        }
        public IHttpActionResult addAdmin(User user)
        {
            return null;
        }
    }
}

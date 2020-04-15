using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineStorePlatform.Controllers
{
    interface DatabaseController
    {
		User getUser(String identifier);
		List<User> getAllUsers();
		bool addUser(User user);
        bool deleteUser(User user);
    }
}

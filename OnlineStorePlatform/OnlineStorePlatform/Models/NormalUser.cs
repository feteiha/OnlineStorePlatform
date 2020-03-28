using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStorePlatform.Models;


namespace OnlineStorePlatform.Models
{
    public class NormalUser : User, StandardUserInterface
    {
        public NormalUser(DB_User u) : base(u)
        {
        }

		public NormalUser(User u) : base(u)
		{
		}
        public bool register(User user)
        {
            return false;
        }
    }
}
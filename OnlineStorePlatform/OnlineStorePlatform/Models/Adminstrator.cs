using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
    public class Adminstrator: User
    {
        public Adminstrator(DB_User u) : base(u)
        {
        }
        public List<User> showAllUsers()
        {
            return null;
        }
        public bool addAdminstrator(User newUser)
        {
            return false;
        }
    }
}
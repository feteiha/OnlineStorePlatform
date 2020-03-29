using System;
using System.Collections.Generic;
using OnlineStorePlatform.Controllers;
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
            DatabaseController DBController = new DatabaseController();
            return DBController.getAllUsers();
        }
        public bool addAdminstrator(User newUser)
        {
            return false;
        }
    }
}
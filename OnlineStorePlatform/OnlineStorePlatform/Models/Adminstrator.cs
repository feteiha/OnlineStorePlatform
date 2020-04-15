using System;
using System.Collections.Generic;
using OnlineStorePlatform.Controllers;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
    public class Adminstrator: User
    {
        public Adminstrator() { }
        public Adminstrator(DB_User u) : base(u)
        {
        }
        public List<User> showAllUsers()
        {
            DatabaseController DBController = new MySQLController();
            List<User> userList = DBController.getAllUsers();
            for ( int i = 0; i < userList.Count; i++)
            {
                userList.ElementAt(i).password = "";
            }
            return userList;
        }
        public bool addAdminstrator(User newUser)
        {
            DatabaseController DBController = new MySQLController();
            User currentUser = DBController.getUser(newUser.username);

            if ( currentUser != null)
            {
                return false;
            }

            currentUser = DBController.getUser(newUser.email);
            if (currentUser != null)
            {
                return false;
            }

            if ( newUser.password.Length < 8 )
            {
                return false;
            }

            DBController.addUser(newUser);
            return true;
        }
    }
}
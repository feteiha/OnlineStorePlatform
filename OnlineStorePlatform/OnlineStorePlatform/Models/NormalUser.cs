using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStorePlatform.Models;
using OnlineStorePlatform.Controllers;

namespace OnlineStorePlatform.Models
{
    public class NormalUser : User, StandardUserInterface
    {
        public NormalUser() { }
        public NormalUser(DB_User u) : base(u)
        {
        }
		public NormalUser(User u) : base(u)
		{
		}
        public bool register()
        {
            bool canAdd = true; 
            List<User> allUsers;
            DatabaseController dataBase = new DatabaseController() ;
            allUsers = dataBase.getAllUsers();
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (this.username == allUsers[i].username)
                    canAdd = false;
            }
            if (!canAdd || this.password.Length < 8 || this.age < 18)
            {
                return false;
            }
            else
            {
                dataBase.addUser(this);
            }


            return true;
        }
    }
}
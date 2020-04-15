using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStorePlatform.Controllers;
using OnlineStorePlatform.Models;

namespace OnlineStorePlatform.Models
{
    public class StoreOwner : User, StandardUserInterface
    {
        public StoreOwner(DB_User u) : base(u)
        {
        }
        public StoreOwner() { }
		public StoreOwner(User u) : base(u)
		{
		}
        public bool register()
        {
            bool canAdd = true;
            List<User> allUsers;
            DatabaseController dataBase = new MySQLController();
            allUsers = dataBase.getAllUsers();
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (this.username == allUsers[i].username || this.email == allUsers[i].email)
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
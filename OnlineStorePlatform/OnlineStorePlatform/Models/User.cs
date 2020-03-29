using OnlineStorePlatform.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
	public abstract class User
	{
        public int id { get; set; }
        public string username { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string gender { get; set; }

        public int age{ get; set; }
        public User ()
        {

        }
        public User(DB_User u)
        {
            this.id = u.BD_Id;
            this.username = u.DB_Username;
            this.email = u.DB_Email;
            this.password = u.DB_Password;
            this.age = (int) u.DB_Age;
        }

		public User(User u)
		{
			this.id = u.id;
			this.username = u.username;
			this.email = u.email;
			this.password = u.password;
			this.age = (int)u.age;
		}

		public static User login(string identifier, string password)
        {
            DatabaseController DBController = new DatabaseController();
            User user = DBController.getUser(identifier);

            if (user != null)
            {
                if (user.password == password)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}

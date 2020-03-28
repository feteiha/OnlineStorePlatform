using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
	public abstract class User
	{
        private int id { get; set; }
        private string username { get; set; }

        private string email { get; set; }

        private string password { get; set; }

        private string gender { get; set; }

        private int age{ get; set; }
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

        public static User login(string identifier, string password)
        {
            return null;
        }
    }
}

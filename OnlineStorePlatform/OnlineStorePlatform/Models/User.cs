using OnlineStorePlatform.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OnlineStorePlatform.Models
{
    [KnownType(typeof(NormalUser))]
    [KnownType(typeof(StoreOwner))]
    [KnownType(typeof(Adminstrator))]
    public abstract class User
    {
        public string fullname  { get; set; }
        public string username  { get; set; }
        public string email     { get; set; }
        public string password  { get; set; }
        public string gender    { get; set; }
        public int    age       { get; set; }

        public User ()
        {

        }
        public User(DB_User u)
        {
            this.fullname = u.DB_Fullname;
            this.username = u.DB_Username;
            this.email = u.DB_Email;
            this.password = u.DB_Password;
            this.gender = u.DB_Gender;
            this.age = (int) u.DB_Age;
        }

		public User(User u)
        {
            this.fullname = u.fullname;
            this.username = u.username;
			this.email = u.email;
			this.password = u.password;
            this.gender = u.gender;
            this.age = (int)u.age;
		}

		public static User login(string identifier, string password)
        {
            DatabaseController DBController = new MySQLController();
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

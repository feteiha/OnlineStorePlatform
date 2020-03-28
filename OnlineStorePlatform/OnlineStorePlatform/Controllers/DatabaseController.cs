using OnlineStorePlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineStorePlatform.Controllers
{
    public class DatabaseController : ApiController
    {
        public User getUser(String identifier)
        {
            OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
            DB_User DBuser = (
                            from u in db.DB_Users
                            where u.DB_Username == identifier
                            || u.DB_Email == identifier
                            select (u)
                        ).FirstOrDefault();
            User user = null;

            if      (DBuser.DB_Type == 0) user = new Adminstrator(DBuser);
            else if (DBuser.DB_Type == 1) user = new NormalUser(DBuser);
            else if (DBuser.DB_Type == 2) user = new StoreOwner(DBuser);
            return user;
        }
        public List<User> getAllUsers()
        {
            OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
            List<DB_User> DB_users = (from u in db.DB_Users
                                       select u).ToList<DB_User>();
            List<User> users = new List<User>();
            for (int i = 0; i < DB_users.Count; i++)
            {
                if (DB_users[i].BD_Id == 1) users.Add(new Adminstrator(DB_users[i]));
                if (DB_users[i].BD_Id == 2) users.Add(new NormalUser(DB_users[i]));
                if (DB_users[i].BD_Id == 3) users.Add(new StoreOwner(DB_users[i]));
            }
            return users;
        }
        public bool addUser(User user)
        {
            /*OnlineStoreDBDataContext db = new OnlineStoreDBDataContext();
            DB_User u = new DB_User();

            u.DB_Username = user.;
            u.DB_Password = user;
            u.DB_Email = user.FName;
            u.DB_Age = user.SName;*/
            return false;
            
        }
    }
}

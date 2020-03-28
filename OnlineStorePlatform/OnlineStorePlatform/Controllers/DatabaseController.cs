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
            if (DBuser.DB_Type == 0)
                user = new Adminstrator(DBuser);

            else if (DBuser.DB_Type == 1)
                user = new NormalUser(DBuser);

            else if (DBuser.DB_Type == 2)
                user = new StoreOwner(DBuser);
            return user;
        }
        public List<User> getAllUsers()
        {
            return null;
        }
        public bool addUser(User user)
        {
            return false ;
        }
    }
}

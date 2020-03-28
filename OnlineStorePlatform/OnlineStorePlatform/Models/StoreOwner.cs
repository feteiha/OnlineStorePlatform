using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStorePlatform.Models
{
    public class StoreOwner : User, StandardUserInterface
    {
        public StoreOwner(DB_User u) : base(u)
        {
        }
        public bool register(User user)
        {
            return false;
        }
    }
}
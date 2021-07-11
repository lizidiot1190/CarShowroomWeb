using CarShowroom.Models;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class UserDAO
    {
        ApplicationDbContext db = null;
        public UserDAO()
        {
            db = new ApplicationDbContext();
        }
        public bool Login(string userName, string passWord)
        {
            var result = db.Users.Count(p => p.userName == userName && p.passWord == passWord);
            if (result > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(p => p.userName == userName);
        }
    }
}
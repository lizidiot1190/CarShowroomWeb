using CarShowroom.Models;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CarShowroom.DAO
{
    public class InfoDAO
    {
        ApplicationDbContext db = null;
        public InfoDAO()
        {
            db = new ApplicationDbContext();
        }
        public Info GetActiveInfo()
        {
            return db.Infos.Single(x => x.status == true);
        }
        public int InsertContact( Contact ct)
        {
            db.Contacts.Add(ct);
            db.SaveChanges();
            return ct.id;

        }
    }
}  
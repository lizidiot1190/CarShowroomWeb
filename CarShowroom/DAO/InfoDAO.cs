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
        public List<Info> ShowInfo()
        {
            return db.Infos.Where(y => y.status != null).OrderBy(x => x.id).ToList();
        }
    }
}
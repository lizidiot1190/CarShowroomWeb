using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class TeamDAO
    {
        ApplicationDbContext db = null;
        public TeamDAO()
        {
            db = new ApplicationDbContext();
        }
        public List<Founder> AllMembers()
        {
            return db.Founders.OrderBy(x => x.id).ToList();
        }
        
        
    }
}
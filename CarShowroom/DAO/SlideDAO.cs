using CarShowroom.Models;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class SlideDAO
    {
        ApplicationDbContext db = null;
        public SlideDAO()
        {
            db = new ApplicationDbContext();
        }
        public List<Slide> ShowSlideList()
        {
            return db.Slides.OrderBy(x => x.id).ToList();
        }
    }
}
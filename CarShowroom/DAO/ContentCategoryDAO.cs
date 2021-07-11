using CarShowroom.Models;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class ContentCategoryDAO
    {
        ApplicationDbContext db = null;
        public ContentCategoryDAO()
        {
            db = new ApplicationDbContext();
        }

        public long Insert(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
    }
}
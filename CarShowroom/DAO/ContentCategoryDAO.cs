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

        public bool Update(Category entity)
        {
            try
            {
                var category = db.Categories.Find(entity.id);
                category.name = entity.name;
                category.metaTitle = entity.metaTitle;
                category.parentID = entity.parentID;
                category.displayOrder = entity.displayOrder;
                category.seoTitle = entity.seoTitle;
                category.status = entity.status;
                category.showOnHome = entity.showOnHome;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Category ViewDetail(int id)
        {
            return db.Categories.Find(id);
        }
    }
}
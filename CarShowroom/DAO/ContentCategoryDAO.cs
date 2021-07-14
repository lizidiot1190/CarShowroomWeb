using CarShowroom.Models;
using Model.EF;
using PagedList;
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
        
        public bool Delete(int id)
        {
            try
            {
                var contentcategory = db.Categories.Find(id);
                db.Categories.Remove(contentcategory);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public Category ViewDetail(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> ListAllPage(int page, int pageSize)
        {
            return db.Categories.OrderByDescending(x=>x.cratedDate).ToPagedList(page, pageSize); 
        }
    }
}
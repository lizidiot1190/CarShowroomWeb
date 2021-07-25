using CarShowroom.Models;
using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class ContentDAO
    {
        ApplicationDbContext db = null;
        public ContentDAO()
        {
            db = new ApplicationDbContext();
        }
        public List<Content> ListNewContents(int top)
        {
            return db.Contents.Where(x => x.topHot != null && x.topHot > DateTime.Now).OrderByDescending(x => x.id).Take(top).ToList();
        }

        public long Insert(Content entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image = "~/assets/img/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/"),fileName);
            entity.imageFile.SaveAs(fileName);
            db.Contents.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(Content entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image = "~/assets/img/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/"), fileName);
            try
            {
                var content = db.Contents.Find(entity.id);
                content.name = entity.name;
                content.metaTitle = entity.metaTitle;
                content.description = entity.description;
                content.image =entity.image;
                content.imageFile = entity.imageFile;
                content.imageFile.SaveAs(fileName);
                content.categoryID = entity.categoryID;
                content.status = entity.status;
                content.topHot = entity.topHot;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public bool Delete(int id)
        {
            try
            {
                var content = db.Contents.Find(id);
                db.Contents.Remove(content);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Content> ListAllPage(int page, int pageSize)
        {
            return db.Contents.OrderByDescending(x => x.categoryID).ToPagedList(page, pageSize);
        }

        public Content ViewDetail(int id)
        {
            return db.Contents.Find(id);
        }


    }
}
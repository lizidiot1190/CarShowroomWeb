using CarShowroom.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class FounderDAO
    {
        private ApplicationDbContext db;
        public FounderDAO()
        {
            db = new ApplicationDbContext();
        }

        public long Insert(Founder entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image= "~/assets/img/founder/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/founder/"), fileName);
            entity.imageFile.SaveAs(fileName);
            db.Founders.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(Founder entity)
        {
            if (entity.imageFile == null)
            {
                try
                {
                    var founder = db.Founders.Find(entity.id);
                    founder.name = entity.name;
                    founder.position = entity.position;
                    founder.link1 = entity.link1;
                    founder.link2 = entity.link2;
                    founder.slogan = entity.slogan;
                    db.SaveChanges();
                    return true;
                }
                catch(Exception)
                {
                    return false;
                }
                
            }
            else
            {

                string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
                string extension = Path.GetExtension(entity.imageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                entity.image = "~/assets/img/founder/" + fileName;
                fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/founder/"), fileName);
                try
                {
                    var founder = db.Founders.Find(entity.id);
                    founder.name = entity.name;
                    founder.position = entity.position;
                    founder.link1 = entity.link1;
                    founder.link2 = entity.link2;
                    founder.slogan = entity.slogan;
                    founder.image = entity.image;
                    founder.imageFile = entity.imageFile;
                    founder.imageFile.SaveAs(fileName);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var founder = db.Founders.Find(id);
                db.Founders.Remove(founder);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public IEnumerable<Founder> ListAllPage(int page, int pageSize)
        {
            return db.Founders.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

        public Founder ViewDetail (int id)
        {
            return db.Founders.Find(id); 
        }
    }
}
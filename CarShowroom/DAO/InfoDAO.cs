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
    public class InfoDAO
    {
        private ApplicationDbContext db;
        public InfoDAO()
        {
            db = new ApplicationDbContext();
        }
<<<<<<< HEAD

        public List<Info> ShowInfo()
        {
            return db.Infos.Where(y => y.status !=null).OrderBy(x => x.id).ToList();
        }
=======
        public List<Info> ShowInfo()
        {
            return db.Infos.Where(y => y.status != null).OrderBy(x => x.id).ToList();
>>>>>>> 5e7f0c0fafb1d87cedeaa4b5a074acaf0f6d93c0

        public long Insert(Info entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
<<<<<<< HEAD
            entity.image = "~/assets/img/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/"), fileName);
=======
            entity.image = "~/assets/img/info/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/info/"), fileName);
>>>>>>> 5e7f0c0fafb1d87cedeaa4b5a074acaf0f6d93c0
            entity.imageFile.SaveAs(fileName);
            db.Infos.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
<<<<<<< HEAD
=======

        public bool Update(Info entity)
        {
            if (entity.imageFile == null)
            {
                try
                {
                    var info = db.Infos.Find(entity.id);
                    info.name = entity.name;
                    info.content = entity.content;
                    info.status = entity.status;
                    info.link = entity.link;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
                    string extension = Path.GetExtension(entity.imageFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    entity.image = "~/assets/img/info/" + fileName;
                    fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/info/"), fileName);

                    var info = db.Infos.Find(entity.id);
                    info.imageFile = entity.imageFile;
                    info.image = entity.image;
                    info.imageFile.SaveAs(fileName);
                    info.name = entity.name;
                    info.content = entity.content;
                    info.status = entity.status;
                    info.link = entity.link;
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
                var info = db.Infos.Find(id);
                db.Infos.Remove(info);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Info> ListAllPage(int page, int pageSize)
        {
            return db.Infos.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

        public Info ViewDetail(int id)
        {
            return db.Infos.Find(id);
        }
>>>>>>> 5e7f0c0fafb1d87cedeaa4b5a074acaf0f6d93c0
    }
}
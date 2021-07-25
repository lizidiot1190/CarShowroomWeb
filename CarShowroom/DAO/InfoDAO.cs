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

        public List<Info> ShowInfo()
        {
            return db.Infos.Where(y => y.status !=null).OrderBy(x => x.id).ToList();
        }

        public long Insert(Info entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image = "~/assets/img/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/"), fileName);
            entity.imageFile.SaveAs(fileName);
            db.Infos.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
    }
}
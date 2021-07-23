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
    public class SlideDAO
    {
        private ApplicationDbContext db;
        public SlideDAO()
        {
            db = new ApplicationDbContext();
        }

        public long Insert(Slide entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image = "~/assets/img/slide/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/slide/"), fileName);
            entity.imageFile.SaveAs(fileName);
            db.Slides.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(Slide entity)
        {
            if (entity.imageFile == null)
            {
                try
                {
                    var slide = db.Slides.Find(entity.id);
                    slide.displayOrder = entity.displayOrder;
                    slide.link = entity.link;
                    slide.description = entity.description;
                    slide.status = entity.status;
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
                    entity.image = "~/assets/img/slide/" + fileName;
                    fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/slide/"), fileName);
                    var slide = db.Slides.Find(entity.id);
                    slide.image = entity.image;
                    slide.imageFile = entity.imageFile;
                    slide.imageFile.SaveAs(fileName);
                    slide.displayOrder = entity.displayOrder;
                    slide.link = entity.link;
                    slide.description = entity.description;
                    slide.status = entity.status;
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
                var slide = db.Slides.Find(id);
                db.Slides.Remove(slide);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public IEnumerable<Slide> ListAllPage(int page, int pageSize)
        {
            return db.Slides.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

        public Slide ViewDetail(int id)
        {
            return db.Slides.Find(id);
        }
    }
}
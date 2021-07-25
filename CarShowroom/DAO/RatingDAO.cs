using CarShowroom.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Model.EF;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom.DAO
{
    public class RatingDAO
    {
        ApplicationDbContext db = null;
        public RatingDAO()
        {
            db = new ApplicationDbContext();
        }

        public List<Rating> ListAllRatings()
        {
            return db.Ratings.OrderByDescending(x => x.id).ToList();
        }

        public long Insert(Rating entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image = "~/assets/img/rating/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/rating/"), fileName);
            entity.imageFile.SaveAs(fileName);
            db.Ratings.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(Rating entity)
        {
            
            if (entity.imageFile==null)
            {
                try
                {
                    var rating = db.Ratings.Find(entity.id);
                    rating.name = entity.name;
                    rating.comment = entity.comment;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
                string extension = Path.GetExtension(entity.imageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                entity.image = "~/assets/img/rating/" + fileName;
                fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/rating/"), fileName);
                try
                {
                    var rating = db.Ratings.Find(entity.id);
                    rating.name = entity.name;
                    rating.image = entity.image;
                    rating.imageFile = entity.imageFile;
                    rating.imageFile.SaveAs(fileName);
                    rating.comment = entity.comment;
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
                var rating = db.Ratings.Find(id);
                db.Ratings.Remove(rating);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        


        public IEnumerable<Rating>ListAllPage(int page, int pageSize)
        {
            return db.Ratings.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

        public Rating ViewDetail(int id)
        {
            return db.Ratings.Find(id);
        }
    }
}
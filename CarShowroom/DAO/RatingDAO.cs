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
            db.Ratings.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(Rating entity)
        {
            try
            {
                var rating = db.Ratings.Find(entity.id);
                rating.name = entity.name;
                rating.comment = entity.comment;
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



        public IEnumerable<Rating> ListAllPage(int page, int pageSize)
        {
            return db.Ratings.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

        public Rating ViewDetail(int id)
        {
            return db.Ratings.Find(id);
        }
    }
}
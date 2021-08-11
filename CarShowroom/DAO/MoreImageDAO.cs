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
    public class MoreImageDAO
    {
        private ApplicationDbContext db = null;
        public MoreImageDAO()
        {
            db = new ApplicationDbContext();
        }

        public string GetImageName(string fileName)
        {
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/moreimages/"), fileName);
            return fileName;
        }

        public string GetImageNameBeforeCombine(string name)
        {
            string fileName = Path.GetFileNameWithoutExtension(name);
            string extension = Path.GetExtension(name);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            return fileName;
        }
        public long Insert(MoreProductImage entity)
        {
            string img1 = GetImageNameBeforeCombine(entity.imageFile1.FileName);
            entity.img1 = "~/assets/img/moreimages/" + img1;
            entity.imageFile1.SaveAs(GetImageName(img1));

            string img2 = GetImageNameBeforeCombine(entity.imageFile2.FileName);
            entity.img2 = "~/assets/img/moreimages/" + img2;
            entity.imageFile2.SaveAs(GetImageName(img2));

            string img3 = GetImageNameBeforeCombine(entity.imageFile3.FileName);
            entity.img3 = "~/assets/img/moreimages/" + img3;
            entity.imageFile3.SaveAs(GetImageName(img3));

            string img4 = GetImageNameBeforeCombine(entity.imageFile4.FileName);
            entity.img4 = "~/assets/img/moreimages/" + img4;
            entity.imageFile4.SaveAs(GetImageName(img4));

            string img5 = GetImageNameBeforeCombine(entity.imageFile5.FileName);
            entity.img5 = "~/assets/img/moreimages/" + img5;
            entity.imageFile5.SaveAs(GetImageName(img5));

            string img6 = GetImageNameBeforeCombine(entity.imageFile6.FileName);
            entity.img6 = "~/assets/img/moreimages/" + img6;
            entity.imageFile6.SaveAs(GetImageName(img6));
            db.MoreProductImages.Add(entity);
            db.SaveChanges();
            return entity.id;

        }

        //public bool Update(MoreProductImage entity)
        //{
        //    var listimage = db.MoreProductImages.Find(entity.id);
        //    if (entity.imageFile1 != null)
        //    {
        //        string img1 = GetImageNameBeforeCombine(entity.imageFile1.FileName);
        //        entity.img1 = "~/assets/img/moreimages/" + img1;
        //        listimage.img1 = entity.img1;
        //        listimage.imageFile1 = entity.imageFile1;
        //        listimage.imageFile1.SaveAs(GetImageName(img1));

        //        if (entity.imageFile2 != null)
        //        {
        //            string img2 = GetImageNameBeforeCombine(entity.imageFile1.FileName);
        //            entity.img2 = "~/assets/img/moreimages/" + img2;
        //            listimage.img2 = entity.img2;
        //            listimage.imageFile2 = entity.imageFile2;
        //            listimage.imageFile2.SaveAs(GetImageName(img2));
        //        }
        //    }
        //    else
        //    {
                
        //    }
        //}

        public bool Delete(int id)
        {
            try
            {
                var listimage = db.MoreProductImages.Find(id);
                db.MoreProductImages.Remove(listimage);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<MoreProductImage> ListAllPage(int page, int pageSize)
        {
            return db.MoreProductImages.OrderByDescending(p => p.id).ToPagedList(page, pageSize);
        }

        public List<Product> ListProductHaveImg()
        {
            return db.Products.Where(p => p.status == true).OrderBy(p => p.categoryID).ToList();
        }

        public MoreProductImage GetItem(int id)
        {
            return db.MoreProductImages.Find(id);
        }
    }
}
using CarShowroom.Models;
using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShowroom.DAO
{
    public class ProductCategoryDAO
    {
        private ApplicationDbContext db;
        public ProductCategoryDAO()
        {
            db = new ApplicationDbContext();
        }

        public long Insert(ProductCategory entity)
        {
            db.ProductCategories.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(ProductCategory entity)
        {
            try
            {
                var productCat = db.ProductCategories.Find(entity.id);
                productCat.name = entity.name;
                productCat.metaTitle = entity.metaTitle;
                productCat.parentID = entity.parentID;
                productCat.displayOrder = entity.displayOrder;
                productCat.seoTitle = entity.seoTitle;
                productCat.status = entity.status;
                productCat.showOnHome = entity.showOnHome;
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
                var productCat = db.ProductCategories.Find(id);
                db.ProductCategories.Remove(productCat);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public IEnumerable<ProductCategory> ListAllPage(int page, int pageSize)
        {
            return db.ProductCategories.OrderByDescending(x => x.createdDate).ToPagedList(page, pageSize);
        }

        public ProductCategory ViewDetail(int id)
        {
            return db.ProductCategories.Find(id);
        }

        public List<ProductCategory> ListCategory()
        {
            return db.ProductCategories.Where(p => p.status == true).OrderByDescending(p => p.id).ToList();
        }
        //public List<Product> ListByCatId(int id)
        //{
        //    return db.Products.Where(p => p.status == true && p.categoryID == id).OrderByDescending(p => p.categoryID).ToList();
        //}
    }
}
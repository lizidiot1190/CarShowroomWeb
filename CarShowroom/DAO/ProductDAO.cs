
using System.Web;
using System.Text;
using System.Threading.Tasks;
﻿using CarShowroom.Models;
using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace CarShowroom.DAO
{
    public class ProductDAO
    {
        private ApplicationDbContext db;
        public ProductDAO()
        {
            db = new ApplicationDbContext();
        }

        public List<Product> ListHotProducts(int top)
        {
            return db.Products.Where(x => x.topHot != null && x.topHot > DateTime.Now).OrderByDescending(x => x.id).Take(top).ToList();
        }

        public long Insert(Product entity)
        {
            string fileName = Path.GetFileNameWithoutExtension(entity.imageFile.FileName);
            string extension = Path.GetExtension(entity.imageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            entity.image = "~/assets/img/product/" + fileName;
            fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/product/"), fileName);
            entity.imageFile.SaveAs(fileName);
            db.Products.Add(entity);
            db.SaveChanges();
            return entity.id;
        }

        public bool Update(Product entity)
        {
            if (entity.imageFile == null)
            {
                try
                {
                    var product = db.Products.Find(entity.id);
                    product.metaTitle = entity.metaTitle;
                    product.name = entity.name;
                    product.loaiXe = entity.loaiXe;
                    product.loaiThung = entity.loaiThung;
                    product.taiTrong = entity.taiTrong;
                    product.namSX = entity.namSX;
                    product.nhapKhau = entity.nhapKhau;
                    product.nhienLieu = entity.nhienLieu;
                    product.description = entity.description;
                    product.price = entity.price;
                    product.promotionPrice = entity.promotionPrice;
                    product.categoryID = entity.categoryID;
                    product.status = entity.status;
                    product.topHot = entity.topHot;
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
                    entity.image = "~/assets/img/product/" + fileName;
                    fileName = Path.Combine(HttpContext.Current.Server.MapPath("~/assets/img/product/"), fileName);
                    var product = db.Products.Find(entity.id);
                    product.metaTitle = entity.metaTitle;
                    product.name = entity.name;
                    product.loaiXe = entity.loaiXe;
                    product.loaiThung = entity.loaiThung;
                    product.taiTrong = entity.taiTrong;
                    product.namSX = entity.namSX;
                    product.nhapKhau = entity.nhapKhau;
                    product.nhienLieu = entity.nhienLieu;
                    product.description = entity.description;
                    product.image = entity.image;
                    product.imageFile = entity.imageFile;
                    product.imageFile.SaveAs(fileName);
                    product.price = entity.price;
                    product.promotionPrice = entity.promotionPrice;
                    product.categoryID = entity.categoryID;
                    product.status = entity.status;
                    product.topHot = entity.topHot;
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
                var product = db.Products.Find(id);
                db.Products.Remove(product);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Product> ListAllPage(int page, int pageSize)
        {
            return db.Products.OrderByDescending(p => p.categoryID).ToPagedList(page, pageSize);
        }

        public Product ViewDetail(int id)
        {
            return db.Products.Find(id);
        }

        

        public List<Product> ListAllProduct()
        {
            return db.Products.Where(p=>p.status== true).OrderByDescending(p => p.categoryID).ToList();
        }
    }
}
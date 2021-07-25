using CarShowroom.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult ListByCatId(int cateId)
        //{
           
        //    var model = new ProductDAO().ListByCatId(cateId);
        //    return View(model);
        //}

        public ActionResult ListAll()
        {
            // var list = new ProductCategoryDAO().ViewDetail(cateId);
            //ViewBag.List = list;
            var listCat = new ProductCategoryDAO().ListCategory();
            ViewBag.List = listCat;
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            var list = new ProductDAO().ListAllProduct();
            return View(list);
        }

        public ActionResult Detail(int id)
        {
            var product = new ProductDAO().ViewDetail(id);
            return View(product);
        }

    }
}
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

        [HttpGet]
        public ActionResult ListByCatId(int id)
        {
            var list = new ProductCategoryDAO().ViewDetail(id);
            ViewBag.Category = list;
            var image1 = new SlideDAO().PickAnImage();
            ViewBag.Image = image1;
            var model = new ProductDAO().ListByCatId(id);
            return View(model);
        }

        public ActionResult ListAll()
        {
            var listCat = new ProductCategoryDAO().ListCategory();
            ViewBag.List = listCat;
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            
            var DAO = new ProductDAO();
            List<Model.EF.Product> list = new List<Model.EF.Product>();
            foreach (var item in listCat)
            {
                var take = DAO.ListAllProduct(4, item.id);
                list.AddRange(take);
            }
            return View(list);
        }

        public ActionResult ListHotProduct()
        {
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            var hotProduct = new ProductDAO().AllHotProducts();
            return View(hotProduct);
        }

        public ActionResult Detail(int id)
        {
            var item = new MoreImageDAO().GetItem(id);
            ViewBag.Item = item;
            var product = new ProductDAO().ViewDetail(id);
            return View(product);
        }

    }
}
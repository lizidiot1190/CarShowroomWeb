using CarShowroom.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var productdao = new ProductDAO();
            ViewBag.HotProducts = productdao.ListHotProducts(6);
            var ratingdao = new RatingDAO();
            ViewBag.Rates = ratingdao.ListAllRatings();
            var contentdao = new ContentDAO();
            ViewBag.Contents = contentdao.ListNewContents(3);
            var showinfo = new InfoDAO();
            ViewBag.Infos = showinfo.ShowInfo();
            var slidedao = new SlideDAO();
            ViewBag.Slides = slidedao.ShowSlideList();
            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}
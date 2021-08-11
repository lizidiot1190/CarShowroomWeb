using CarShowroom.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Controllers
{
    public class RatingController : Controller
    {
        // GET: Rating

        public ActionResult Rating()
        {
            var ratingdao = new RatingDAO();
            ViewBag.Rates = ratingdao.ListAllRatings();
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            return View();
        }
    }
}
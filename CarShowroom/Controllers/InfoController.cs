using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarShowroom.DAO;
using CarShowroom.Models;
using Model.EF;
namespace CarShowroom.Controllers
{
    public class InfoController : Controller
    {
        //GET: Info
        public ActionResult Index()
        {
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            var showinfo = new InfoDAO();
            ViewBag.Infos = showinfo.ShowInfo();
            var nolinkinfo = new InfoDAO().GetInfoWithouLink();
            ViewBag.NoLinkInfo = nolinkinfo;
            return View();
        }
    }
}
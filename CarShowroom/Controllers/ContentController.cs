using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using CarShowroom.Models;
using Model.EF;

namespace CarShowroom.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ApplicationDbContext db = new ApplicationDbContext();
        private List<Content> GetContentList()
        {
            return db.Contents.ToList();
        }
        public ContentController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index1(int? page)
        {
            if (page == null) page = 1;
            var listContent = GetContentList();
            int pageSize = 4;
            int pageNum = (page ?? 1);
            return View(listContent.ToPagedList(pageNum, pageSize));
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}
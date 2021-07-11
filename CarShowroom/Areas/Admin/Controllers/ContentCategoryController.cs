using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class ContentCategoryController : Controller
    {
        // GET: Admin/ContentCategory
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ContentCategoryDAO();
                long id = DAO.Insert(category);
                if (id > 0)
                {
                    return RedirectToAction("Index", "ContentCategory");

                }
                else
                {
                    ModelState.AddModelError("", "Thêm user không thành công!");
                }
            }
            return View("Index");

        }
    }
}
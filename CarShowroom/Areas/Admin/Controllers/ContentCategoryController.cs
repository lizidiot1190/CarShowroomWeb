using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class ContentCategoryController : SessionController
    {
        // GET: Admin/ContentCategory
        public ActionResult Index(int page = 1, int pageSize = 1)
        {
            var DAO = new ContentCategoryDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var category = new ContentCategoryDAO().ViewDetail(id);
            return View(category);
        }
        [HttpPost]
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
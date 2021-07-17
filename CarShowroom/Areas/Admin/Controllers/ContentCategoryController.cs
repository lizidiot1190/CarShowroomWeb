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
        public ActionResult Index(int page = 1, int pageSize = 10)
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
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var contentcategory = new ContentCategoryDAO().ViewDetail(id);
            return View(contentcategory);
        }
        [HttpPost]
        public ActionResult Edit(ContentCategory category)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ContentCategoryDAO();
                var result = DAO.Update(category);
                if (result)
                {
                    return RedirectToAction("Index", "ContentCategory");
                }
                else
                {
                    ModelState.AddModelError("", "Sửa danh mục không thành công!");
                }
                
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult Create(ContentCategory category)
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
                    ModelState.AddModelError("", "Thêm danh mục không thành công!");
                }
            }
            return View("Index");

        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new ContentCategoryDAO().Delete(id);
            return RedirectToAction("Index");
        }
    }
}
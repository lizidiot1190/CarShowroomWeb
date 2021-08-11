using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class ContentController : SessionController
    {
        // GET: Admin/Content
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var DAO = new ContentDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Content content)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ContentDAO();
                long id = DAO.Insert(content);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Content");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm content không thành công!");
                }
            }
            return View("Index");
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var content = new ContentDAO().ViewDetail(id);
            return View(content);
        }
        [HttpPost]
        public ActionResult Edit(Content content)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ContentDAO();
                var result = DAO.Update(content);
                if (result)
                {
                    return RedirectToAction("Index", "Content");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật không thành công!");
                }
            }
            return View("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ContentDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "Content");
                }
                else
                {
                    ModelState.AddModelError("", "Không thể xóa dữ liệu!");
                }
            }
            return View("Index");
        }
    }

}
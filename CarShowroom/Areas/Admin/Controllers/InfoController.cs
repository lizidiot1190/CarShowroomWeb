using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class InfoController : SessionController
    {
        // GET: Admin/Info
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var DAO = new InfoDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Info info)
        {
            if (ModelState.IsValid)
            {
                var DAO = new InfoDAO();
                var id = DAO.Insert(info);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Info");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm mới dữ liệu không thành công!");
                }
            }
            return View("Index");
        }
        

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var info = new InfoDAO().ViewDetail(id);
            return View(info);
        }

        [HttpPost]
        public ActionResult Edit(Info info)
        {
            if (ModelState.IsValid)
            {
                var DAO = new InfoDAO();
                var result = DAO.Update(info);
                if (result)
                {
                    return RedirectToAction("Index", "Info");
                }
                else
                {
                    ModelState.AddModelError("", "Cập nhật dữ liệu không thành công!");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var DAO = new InfoDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "Info");
                }
                else
                {
                    ModelState.AddModelError("", "Xoá dữ liệu không thành công!");
                }
            }
            return View("Index");
        }
    }
}
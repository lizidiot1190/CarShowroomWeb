using CarShowroom.DAO;
using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class FounderController : SessionController
    {
        // GET: Admin/Founder
        public ActionResult Index(int page=1, int pageSize=10)
        {
            var DAO = new FounderDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Founder founder)
        {
            if (ModelState.IsValid)
            {
                var DAO = new FounderDAO();
                var id = DAO.Insert(founder);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Founder");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm dữ liệu không thành công!");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var founder = new FounderDAO().ViewDetail(id);
            return View(founder);
        }

        [HttpPost]
        public ActionResult Edit(Founder founder)
        {
            if (ModelState.IsValid)
            {
                var DAO = new FounderDAO();
                var result = DAO.Update(founder);
                if (result)
                {
                    return RedirectToAction("Index", "Founder");
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
                var DAO = new FounderDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "Founder");
                }
                else
                {
                    ModelState.AddModelError("", "Xóa dữ liệu không thành công!");
                }
            }
            return View("Index");
        }
    }
}
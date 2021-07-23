using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class SlideController : SessionController
    {
        // GET: Admin/Slide
        public ActionResult Index(int page=1,int pageSize=10)
        {
            var DAO = new SlideDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Slide slide)
        {
            if (ModelState.IsValid)
            {
                var DAO = new SlideDAO();
                var id = DAO.Insert(slide);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Slide");
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
            var slide = new SlideDAO().ViewDetail(id);
            return View(slide);
        }
        [HttpPost]
        public ActionResult Edit(Slide slide)
        {
            if (ModelState.IsValid)
            {
                var DAO = new SlideDAO();
                var result = DAO.Update(slide);
                if (result)
                {
                    return RedirectToAction("Index", "Slide");
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
                var DAO = new SlideDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "Slide");
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
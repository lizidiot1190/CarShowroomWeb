using CarShowroom.DAO;
using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class RatingController : SessionController
    {
        // GET: Admin/Rating
        public ActionResult Index(int page=1, int pageSize=10)
        {
            var DAO = new RatingDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Rating rating)
        {
            if (ModelState.IsValid)
            {
                var DAO = new RatingDAO();
                var id = DAO.Insert(rating);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Rating");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm đánh giá không thành công");
                }

            }
            return View("Index");
            
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var rating = new RatingDAO().ViewDetail(id);
            return View(rating);
        }
        [HttpPost]
        public ActionResult Edit(Rating rating)
        {
            if (ModelState.IsValid)
            {
                var DAO = new RatingDAO();
                var result = DAO.Update(rating);
                if (result)
                {
                    return RedirectToAction("Index", "Rating");
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
                var DAO = new RatingDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Rating", "Index");
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
using CarShowroom.DAO;
using CarShowroom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class MoreImageController : SessionController
    {
        // GET: Admin/MoreImage
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var model = new MoreImageDAO().ListAllPage(page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            var listProductImage = new MoreImageDAO().ListProductHaveImg();
            ViewBag.ListImage = (from item in listProductImage
                                 select new SelectListItem
                                 {
                                     Text = item.name,
                                     Value = item.id.ToString(),
                                 });
            return View();
        }
        [HttpPost]
        public ActionResult Create(MoreProductImage image)
        {
            if (ModelState.IsValid)
            {
                var DAO = new MoreImageDAO();
                var id = DAO.Insert(image);
                if (id > 0)
                {
                    return RedirectToAction("Index", "MoreImage");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm dữ liệu không thành công!");
                }
            }
            return View("Index");
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var DAO = new MoreImageDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "MoreImage");
                }
                else
                {
                    ModelState.AddModelError("", "Xóa dữ liệu không thành công");
                }
            }
            return View("Index");
        }
    }
}
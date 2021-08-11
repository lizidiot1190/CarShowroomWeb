using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class ProductController : SessionController
    {
        // GET: Admin/Product
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var DAO = new ProductDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var category = new ProductCategoryDAO().ListCategory();
            ViewBag.Category = (from item in category
                                select new SelectListItem
                                {
                                    Text = item.name,
                                    Value = item.id.ToString()

                                });
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ProductDAO();
                var id = DAO.Insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Product");
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
            var product = new ProductDAO().ViewDetail(id);
            var category = new ProductCategoryDAO().ListCategory();
            ViewBag.Category = (from item in category
                                select new SelectListItem
                                {
                                    Text = item.name,
                                    Value = item.id.ToString()

                                });
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ProductDAO();
                var result = DAO.Update(product);
                if (result)
                {
                    return RedirectToAction("Index", "Product");
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
                var DAO = new ProductDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "Product");
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
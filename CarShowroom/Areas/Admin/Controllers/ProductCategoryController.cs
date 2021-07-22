using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class ProductCategoryController : SessionController
    {
        // GET: Admin/ProductCategory
        public ActionResult Index(int page=1, int pageSize=10)
        {
            var DAO = new ProductCategoryDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductCategory productCat)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ProductCategoryDAO();
                long id = DAO.Insert(productCat);
                if (id > 0)
                {
                    return RedirectToAction("Index","ProductCategory");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm danh mục không thành công!");
                }
            }
            return View("Index");
            
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var productCat = new ProductCategoryDAO().ViewDetail(id);
            return View(productCat);
        }
        [HttpPost]
        public ActionResult Edit(ProductCategory productCat)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ProductCategoryDAO();
                var result = DAO.Update(productCat);
                if (result)
                {
                    return RedirectToAction("Index", "ProductCategory");

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
            new ProductCategoryDAO().Delete(id);
            return JavaScript("windows.location ='" + Url.Action("Index", "ProductCategory") + "'");
        }
    }
}
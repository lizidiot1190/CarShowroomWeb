using CarShowroom.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class ContactController : SessionController
    {
        // GET: Admin/Contact
        public ActionResult Index(int page=1,int pageSize=10)
        {
            var DAO = new ContactDAO();
            var model = DAO.ListAllPage(page, pageSize);
            return View(model);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var DAO = new ContactDAO();
                var result = DAO.Delete(id);
                if (result)
                {
                    return RedirectToAction("Index", "Contact");
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
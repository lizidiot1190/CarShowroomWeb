using CarShowroom.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        [HttpGet]
        public ActionResult Contact()
        {
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            if (ModelState.IsValid)
            {
                var DAO = new ContactDAO();
                var id = DAO.Insert(contact);
                if (id > 0)
                {
                    SetAlert("Đã gửi thành công!", 1);
                }
                else
                {
                    ModelState.AddModelError("", "Gửi không thành công!");
                }

            }
            return View();
        }

        protected void SetAlert(string message, int type)
        {
            TempData["AlertMessage"] = message;
            if (type == 1)
            {
                TempData["AlertType"] = "alert-success";
            }
            else
            {
                TempData["AlertType"] = "alert-warning";
            }
        }
    }
}
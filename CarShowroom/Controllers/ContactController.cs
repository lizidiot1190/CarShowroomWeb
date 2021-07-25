using CarShowroom.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace CarShowroom.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult contact()
        {
            var model = new InfoDAO().GetActiveInfo();   
            return View(model) ;
        }
        [HttpPost]
        public JsonResult Submit(string name, string phoneNumber, string email, string address, string content)
        {
            var contact = new  Contact();
            contact.name = name;  
            contact.phoneNumber  = phoneNumber;
            contact.email = email; 
            contact.address = address;
            contact.content = content;
            contact.createdDate = DateTime.Now;

            var id = new InfoDAO().InsertContact(contact);
            if (id > 0)
                return Json(new
                {
                    status = true
                });
            else
                return Json(new
                {
                    status = false
                });
                    

        }
    } 
}    
using CarShowroom.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShowroom.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Team()
        {
            var teamdao = new TeamDAO();
            ViewBag.Teams = teamdao.AllMembers();
            var image = new SlideDAO().PickAnImage();
            ViewBag.Image = image;
            return View();
        }
    }
}
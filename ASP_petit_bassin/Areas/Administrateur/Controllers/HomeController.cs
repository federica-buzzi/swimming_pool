using ASP_petit_bassin.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_petit_bassin.Areas.Administrateur.Controllers
{
    public class HomeController : Controller
    {
        // GET: Administrateur/Home
        public ActionResult Index()
        {
            if (!SessionUtils.IsLogged) return RedirectToAction("Login", "Admin", new { area = "" });

            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon(); 
            return RedirectToAction("Index", "Home", new {area=""}); 
        }
    }
}
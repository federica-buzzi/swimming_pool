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
            return View();
        }
    }
}
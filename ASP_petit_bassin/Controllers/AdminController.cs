using ASP_petit_bassin.Infra;
using swimming_pool_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_petit_bassin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home", new { area=""}); 
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AdminModel firstAdmin)
        {
            if( ModelState.IsValid)
            {
                if (firstAdmin.AdminName != "Fede" && firstAdmin.AdminPassword != "brol")
                {
                    ViewBag.Error = "Erreur Login/Password"; 
                    return View();
                }
                else
                {
                    SessionUtils.IsLogged = true;
                    return RedirectToAction("Index", "Home", new { area = "Administrateur" });
                }

            }
            else
            {
                return View(); 
            }
            
        }
    }
}
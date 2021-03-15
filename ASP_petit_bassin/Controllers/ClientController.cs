using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_petit_bassin.Infra;
using swimming_pool_models;
using swimming_pool_repositories;

namespace ASP_petit_bassin.Controllers
{
    public class ClientController : Controller
    {
        UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        
        // GET: Client

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(UserModel firstUser)
        {
            if (ModelState.IsValid)
            {
                if (uow.CreateUser(firstUser))
                {
                    SessionUtils.IsLogged = true;
                    SessionUtils.ConnectedUser = firstUser;
                    return RedirectToAction("Index", "Home", new { area = "Membre" });
                }
                else
                {
                    ViewBag.Error = "Pas en DB";
                    return View(firstUser);
                }
            }
            else
            {
                ViewBag.Error = "Champs requis";
                return View(firstUser);
            }
        }
    }
}
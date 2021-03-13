using ASP_petit_bassin.Models;
using swimming_pool_models;
using swimming_pool_repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_petit_bassin.Controllers
{
    public class HomeController : Controller
    {
        //si le formulaire est dans la meme page que toute le reste je fais un HttpGet avant l'Index()?
        [HttpGet]
        public ActionResult Index()
        {
            HomeViewModel hm = new HomeViewModel();
            return View(hm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(BookingFormModel MyBookingModel)
        {
            HomeViewModel hm = new HomeViewModel();
            if (ModelState.IsValid)
            {
                //je recupere la connectionString
                UnitOfWork uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                if (uow.SaveBooking(MyBookingModel))
                {
                    ViewBag.SuccessMessage = "Rendez-vous enregistré"; 
                    return View(hm);
                }
                else
                {
                    ViewBag.ErrorMessage = "Rendez vous pas enregistré";
                    return View(hm);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                return View(hm);
            }
        }
        //correct de retourner chaque fois une view(hm)?

 
    }
}
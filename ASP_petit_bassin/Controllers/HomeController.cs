using ASP_petit_bassin.Models;
using swimming_pool_models;
using System;
using System.Collections.Generic;
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
        public ActionResult BookingForm(BookingFormModel MyBookingModel)
        {
            return View(); 
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}
using PluralsightMVC4OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PluralsightMVC4OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFood _db = new OdeToFood();  

        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList(); 

            return View(model);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";
            //ViewBag.Location = "MaryLand , USA"; 
            var model = new AboutModel();
            model.Name = "Alan ";
            model.Location = "Maryland, USA"; 

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose(); 
            }
            base.Dispose(disposing); 
        }

    }
}

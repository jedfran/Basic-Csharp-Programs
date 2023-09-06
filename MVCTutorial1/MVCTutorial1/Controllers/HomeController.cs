using MVCTutorial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.ID = 1;
            user.FirstName = "Jedo";
            user.LastName = "Francisco";
            user.Age = 20;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

           

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using _194MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _194MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};

            //return View(names);

            //int number = 5;

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jeremy";
            user.LastName = "Henderson";
            user.Age = 22;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}
using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApp.Controllers
{    
    public class HomeController : Controller
    {
        CodeFirstContext context = new CodeFirstContext();

        public ActionResult Index()
        {
            var data = context.Subjects.Include("Student").ToList();
            return View(data);
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
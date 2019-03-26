using AjaxTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTutorial.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createStudent(Student std)
        {
            context.Students.Add(std);
            context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }
        public JsonResult getStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = context.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}
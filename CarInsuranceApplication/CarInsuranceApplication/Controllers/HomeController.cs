using CarInsuranceApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceApplication.Controllers
{
    public class HomeController : Controller
    {    
        public ActionResult Index()
        {           
                return View();
        }

        [HttpPost]
        public ActionResult Application(string firstName, string lastName, string emailAddress, DateTime? dateOfBirth, int? carYear, string carMake, string carModel, int? tickets, bool DUI = false, bool coverage = false)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || tickets == null || carYear == null || dateOfBirth == null)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //error page video page 235
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    int agePremium = 0;
                    int carAgePremium = 0;
                    int porschePremium = 0;
                    int carerraPremium = 0;
                    int ticketPremium = Convert.ToInt32(tickets) * 10;
                    DateTime Birthday;
                    Birthday = (DateTime)dateOfBirth;
                    
                    if (Birthday.AddYears(18) > DateTime.Now)
                    {
                        agePremium = 100;
                    }
                    else if (Birthday.AddYears(25) > DateTime.Now || Birthday.AddYears(100) < DateTime.Now)
                    {
                        agePremium = 25;
                    }
                    
                    if (carYear < 2000 || carYear > 2015)
                    {
                        carAgePremium = 25;
                    }
                    if (carMake == "Porsche")
                    {
                        porschePremium = 25;
                    }
                    if (carModel == "911 Carerra")
                    {
                        carerraPremium = 25;
                    }
                    
                    double cost = 50 + agePremium + carAgePremium + porschePremium + carerraPremium + ticketPremium;

                    if (DUI == true)
                    {
                        cost = cost * 1.25;
                    }
                    if (coverage == true)
                    {
                        cost = cost * 1.5;
                    }
                    int? quote = Convert.ToInt32(cost);

                    var application = new ApplicantInfo();
                    application.FirstName = firstName;
                    application.LastName = lastName;
                    application.EmailAddress = emailAddress;
                    application.DateOfBirth = Birthday;
                    application.CarYear = carYear;
                    application.CarMake = carMake;
                    application.CarModel = carModel;
                    application.DUI = DUI;
                    application.NumTickets = tickets;
                    application.Coverage = coverage;
                    application.Quote = quote;
                    

                    db.ApplicantInfoes.Add(application);
                    db.SaveChanges();

                    return View("Quote", application);
                }                
            }            
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var applications = db.ApplicantInfoes.ToList();
                var applicationVms = new List<ApplicationVm>();
                foreach (var application in applications)
                {
                    var applicationVm = new ApplicationVm();
                    applicationVm.Id = application.Id;
                    applicationVm.FirstName = application.FirstName;
                    applicationVm.LastName = application.LastName;
                    applicationVm.EmailAddress = application.EmailAddress;
                    applicationVm.Quote = application.Quote;
                    applicationVms.Add(applicationVm);
                }
                return View("~/Views/Admin/Index.cshtml",applicationVms);
            }
        }
    }
}
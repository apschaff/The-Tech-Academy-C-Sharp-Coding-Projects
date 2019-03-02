using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceApplication.Models
{
    //This file is a model. A simple class. This maps exactly to the Insurance Database. 
    public class ApplicationSubmission
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int NumTickets { get; set; }
        public bool Coverage { get; set; }
        public int Quote { get; set; }
    }
}
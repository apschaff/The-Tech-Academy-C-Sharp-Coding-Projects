using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public class Subject
    {
        public Subject()
        {
        }
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string SubjectCode { get; set; }
        public Student Student { get; set; }
    }
}
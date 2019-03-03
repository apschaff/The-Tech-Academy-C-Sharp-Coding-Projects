using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Models
{
    public class Student
    {
        public Student()
        {
            Subjects = new List<Subject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Subject>Subjects { get; set; }
    }
}
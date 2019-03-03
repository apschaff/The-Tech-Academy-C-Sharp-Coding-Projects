using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstApp.Models
{
    public partial class CodeFirstContext : DbContext
    {
        public CodeFirstContext() : base("Name=MyContext")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
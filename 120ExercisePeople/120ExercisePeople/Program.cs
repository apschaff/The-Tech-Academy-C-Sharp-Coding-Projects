using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120ExercisePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            //if I change the Person variables and SayName Method to static, this works, but then I cannot pass the values above into the method. 
            person.SayName();
            employee.SayName();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _126ExerciseInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employee.SayName();
            Console.ReadLine();

            IQuittable quit = new Employee();
            quit.Quit();
            Console.ReadLine();
        }
    }
}

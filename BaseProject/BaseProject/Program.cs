using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129ExerciseOperatorOverlaod
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public abstract void SayName();
    }

    public class Employee : Person, IQuittable
    {
        //What does it mean to implement the SayName method here?
        public override void SayName()
        {
            Console.WriteLine("SayName worked inside the Employee class");
        }
        public void Quit()
        {
            Console.WriteLine("Method Quit has been implemented.");
        }
    }

    interface IQuittable
    {
        void Quit();
    }

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
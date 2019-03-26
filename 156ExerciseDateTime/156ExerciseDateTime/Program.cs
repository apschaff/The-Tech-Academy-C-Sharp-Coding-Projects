using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _156ExerciseDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The current date and time is: ");
            Console.WriteLine(DateTime.Now);
            Console.Write("\nPlease enter a number: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime futureTime = currentTime.AddHours(hours);
            Console.WriteLine("\nIn {0} hours, it will be {1}.", hours, futureTime);
            Console.Read();
        }
    }
}

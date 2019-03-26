using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBranching92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package express. Please follow the instructions below");
            
            Console.WriteLine("Please enter the package weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length");
            double length = Convert.ToDouble(Console.ReadLine());

            if (width + height + length > 50)
            {
                Console.WriteLine("Package to big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            double quote = (width + length + height) * weight / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you.");

            Console.ReadLine();
        }
    }
}

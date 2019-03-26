using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162ExerciseFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a const variable
            const string Name = "Andrew";

            //Create a variable using the keyword "var"
            Console.Write("Please Enter a number: ");
            var inputNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your name: ");
            string nameInput = Console.ReadLine();
            //Console.WriteLine("Please enter your age. If you do not wish to enter your age press enter.");
            //int ageInput = Convert.ToInt32(Console.ReadLine());
            //Person individual = new Person(nameInput, ageInput);

            //Console.WriteLine("Your name is {0}, and you are {1} years old.", nameInput, ageInput);
            Console.Read();
        }
    }
}

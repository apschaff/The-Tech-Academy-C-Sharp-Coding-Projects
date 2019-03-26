using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113ExerciseMethod
{
    partial class Program
    {
        static void Main(string[] args)
        {            
            Calculation calculation = new Calculation();

            Console.WriteLine("Please type a number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type another number.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            calculation.Add(number1, number2);

            Console.WriteLine("The second set of numbers is first 5 and 8.");
            calculation.Add(num1: 5, num2: 8);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115ExerciseMethods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number if you wish. If you do not want to enter a number press \"Enter\".");
            string value = Console.ReadLine();

            if (string.IsNullOrEmpty(value))
            {
                var sum = math.Add(number1);
                Console.WriteLine("Your number plus ten is: " + sum);
            }
            else
            {
                int number2 = Convert.ToInt32(value);
                var sum = math.Add(number1, number2);
                Console.WriteLine("The sum of your numbers is: " + sum);
            }
                                    
            Console.ReadLine();
        }
    }
}

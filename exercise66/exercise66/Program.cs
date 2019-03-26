using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string num1 = Console.ReadLine();
            double number1 = Convert.ToDouble(num1);
            number1 = number1 * 50;
            Console.WriteLine("your number times 50 is: " + number1);

            Console.WriteLine("Please enter another number.");
            string num2 = Console.ReadLine();
            double number2 = Convert.ToDouble(num2);
            number2 = number2 + 25;
            Console.WriteLine("your number plus 25 is: " + number2);

            Console.WriteLine("Please enter a third number.");
            string num3 = Console.ReadLine();
            double number3 = Convert.ToDouble(num3);
            number3 = number3 / 12.5;
            Console.WriteLine("your number divided by 12.5 is: " + number3);

            Console.WriteLine("Please enter a fourth number.");
            string num4 = Console.ReadLine();
            double number4 = Convert.ToDouble(num4);
            bool trueOrFalse = number4 > 50;
            Console.WriteLine("your number is greater than 50: " + trueOrFalse.ToString());

            Console.WriteLine("Please enter one last number.");
            string num5 = Console.ReadLine();
            double number5 = Convert.ToDouble(num5);
            double remainder = number5 % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);

            Console.Read();
        }
    }
}

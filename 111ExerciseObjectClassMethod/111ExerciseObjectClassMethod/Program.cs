using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111ExerciseObjectClassMethod
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //instantiate class math mathMethods. This allows Program.cs to access MathMethods.cs but is not necessary if MathMethods.cs is declared as a static class.
            Calculation calculation = new Calculation();


            Console.WriteLine("Please enter a number for performing math operations.");
            int x = Convert.ToInt32(Console.ReadLine());            
            var addAnswer = calculation.Add(x);
            Console.WriteLine("Your number plus ten is: " + addAnswer);

            Console.WriteLine("Please enter another number for performing math operations.");
            int y = Convert.ToInt32(Console.ReadLine());
            var subtractAnswer = calculation.Subtract(y);
            Console.WriteLine("Your number minus two is: " + subtractAnswer);

            Console.WriteLine("Please enter one more number for performing math operations.");
            int z = Convert.ToInt32(Console.ReadLine());
            var multiplyAnswer = calculation.Multiply(z);
            Console.WriteLine("Your number times five is: " + multiplyAnswer);
            Console.ReadLine();            
        }
    }
}

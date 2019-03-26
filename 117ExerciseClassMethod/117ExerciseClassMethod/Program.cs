using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117ExerciseClassMethod
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();

            Console.WriteLine("Please enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2;

            number.Divide(out num2, num1);
            Console.WriteLine(num2);

            var addAnswer = number.Add(num1);
            Console.WriteLine(addAnswer);

            Console.WriteLine("Please enter another number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            
            var add2Answer = number.Add(num3);
            Console.WriteLine(add2Answer);

            
            Console.ReadLine();
        }
    }
}

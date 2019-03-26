using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114ExerciseMethods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            mathOps mathops = new mathOps();

            //Console.WriteLine("Please type a number: ");
            int input1 = 12; // Convert.ToInt32(Console.ReadLine());
            var addResult1 = mathops.Add(input1);
            Console.WriteLine("The result of the first addition equation is: " + addResult1);


            decimal input2 = 397.76349187236M;
            var addResult2 = mathops.Add(input2);
            Console.WriteLine("The result of the second addition equation converted to an integer is: " + addResult2);


            Console.WriteLine("Please enter a number: ");
            string input3 = Console.ReadLine();
            var addResult3 = mathops.Add(input3);
            if (addResult3 != 0)
            {
                Console.WriteLine("The result of the third addition equation converted to an integer is: " + addResult3);
            }
            else
            {
                Console.WriteLine("please enter a whole number next time.");
            }

            Console.ReadLine();
        }
    }
}

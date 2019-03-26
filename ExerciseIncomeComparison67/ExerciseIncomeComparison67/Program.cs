using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseIncomeComparison67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hRate1 = Console.ReadLine();
            Console.WriteLine("Hours Worked?");
            string hWorked1 = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hRate2 = Console.ReadLine();
            Console.WriteLine("Hours Worked?");
            string hWorked2 = Console.ReadLine();

            double rate1 = Convert.ToDouble(hRate1);
            double worked1 = Convert.ToDouble(hWorked1);
            double salary1 = rate1 * worked1;
            Console.WriteLine("Weekly salary of Person 1: " + salary1);

            double rate2 = Convert.ToDouble(hRate2);
            double worked2 = Convert.ToDouble(hWorked2);
            double salary2 = rate2 * worked2;
            Console.WriteLine("Weekly salary of Person 2: " + salary2);
            
            Console.WriteLine("Does Person 1 make more than Person 2?");            
            bool trueOrFalse = salary1 > salary2;
            Console.WriteLine(trueOrFalse.ToString());
            
            Console.Read();
        }
    }
}

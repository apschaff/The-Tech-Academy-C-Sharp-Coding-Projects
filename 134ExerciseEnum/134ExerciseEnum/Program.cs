using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134ExerciseEnum
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string Day = Console.ReadLine();

            try
            {
                Enum.Parse(typeof(DaysOfTheWeek), Day);
                Console.WriteLine("The day you entered, " + Day + ", is part of the enum.");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week in the format \"Wednesday\": ");
            }

            Console.ReadLine();           
        }
    }
}

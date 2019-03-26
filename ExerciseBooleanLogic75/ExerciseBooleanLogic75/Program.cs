using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBooleanLogic75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int appAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? (Please enter 'true' or'false')");
            string DUIs = Console.ReadLine();
            bool DUI = Convert.ToBoolean(DUIs);

            Console.WriteLine("How many speeding tikets do you have?");
            string tickets = Console.ReadLine();
            int numTickets = Convert.ToInt32(tickets);

            Console.WriteLine("Qualified?");
            Console.WriteLine(appAge > 15 && DUI == false && numTickets <= 3);
            
            Console.ReadLine();
        }
    }
}

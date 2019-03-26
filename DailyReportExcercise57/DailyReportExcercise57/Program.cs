using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportExcercise57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");

            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needHelp);
            //if (helpNeeded == true) Console.WriteLine("An instructor will be in contact with you soon.");
            //Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string numberHours = Console.ReadLine();
            int numHours = Convert.ToInt32(numberHours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to you shortly. Have a great day!");
            
            Console.ReadLine();


        }
    }
}

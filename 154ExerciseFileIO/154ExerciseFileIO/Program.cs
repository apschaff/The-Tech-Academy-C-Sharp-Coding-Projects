using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _154ExerciseFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Andrew\Programming\Logs\154exercise.txt", number);
            string numberFile = File.ReadAllText(@"C:\Users\Andrew\Programming\Logs\154exercise.txt");
            Console.WriteLine(numberFile);
            Console.Read();
        }
    }
}

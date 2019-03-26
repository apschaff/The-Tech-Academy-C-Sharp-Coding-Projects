using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _129ExerciseOperatorOverlaod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeObject = new Employee<string>();

            employeeObject.things = new List<string> {"dog", "cat", "phone", "apple", "shirt", "tire"};

            Employee<int> employeeNumber = new Employee<int>();

            employeeNumber.things = new List<int> { 1, 2, 3, 4, 5, 6 };

            foreach (string thing in employeeObject.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeeNumber.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}

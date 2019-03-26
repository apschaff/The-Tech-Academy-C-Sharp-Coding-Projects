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
            Employee employee1 = new Employee()
            {
                firstName = "Sample1",
                lastName = "Student",
                ID = 1                
            };

            Employee employee2 = new Employee()
            {
                firstName = "Sample2",
                lastName = "Student",
                ID = 2
            };
                        
            //uses operator overload to check if employee1's id is equal to employee2's id
            Console.WriteLine("Employee ID's are equal: ");
            Console.WriteLine(employee1 == employee2);
                        
            Console.ReadLine();
        }
    }
}

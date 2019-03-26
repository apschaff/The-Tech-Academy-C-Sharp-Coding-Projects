using System;
using System.Collections.Generic;
using System.Linq;

namespace _140ExerciseLambdaExpressions
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee1 = new Employee()
            {
                firstName = "Joe",
                lastName = "Martin",
                ID = 1
            };

            Employee employee2 = new Employee()
            {
                firstName = "Marcos",
                lastName = "Olivas",
                ID = 2
            };
            Employee employee3 = new Employee()
            {
                firstName = "Darren",
                lastName = "O'Reiley",
                ID = 3
            };

            Employee employee4 = new Employee()
            {
                firstName = "Danielle",
                lastName = "Aris",
                ID = 4
            };
            Employee employee5 = new Employee()
            {
                firstName = "Harry",
                lastName = "Grey",
                ID = 5
            };

            Employee employee6 = new Employee()
            {
                firstName = "Karen",
                lastName = "Duluth",
                ID = 6
            };
            Employee employee7 = new Employee()
            {
                firstName = "Joe",
                lastName = "Smith",
                ID = 7
            };

            Employee employee8 = new Employee()
            {
                firstName = "Lilly",
                lastName = "Waterman",
                ID = 8
            };
            Employee employee9 = new Employee()
            {
                firstName = "Dirk",
                lastName = "Holtzman",
                ID = 9
            };

            Employee employee10 = new Employee()
            {
                firstName = "Maria",
                lastName = "Chavez",
                ID = 10
            };

            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);
            employeeList.Add(employee6);
            employeeList.Add(employee7);
            employeeList.Add(employee8);
            employeeList.Add(employee9);
            employeeList.Add(employee10);

            Console.WriteLine("Complete employee list:");
            employeeList.ForEach(k => Console.WriteLine("{0} {1} {2}\t", k.firstName, k.lastName, k.ID));

            Console.WriteLine("Here is a list of employees with the first name Joe.");
            Console.WriteLine("ForEach loop results:");

            List<Employee> JoeList1 = new List<Employee>();
            foreach (Employee individual in employeeList)
            {
                if (individual.firstName == "Joe")
                {
                    JoeList1.Add(individual);
                    Console.WriteLine(individual.firstName + " " + individual.lastName + " " + individual.ID);
                }
            }

            Console.WriteLine("Lambda expression results:");

            List<Employee> JoeList2 = new List<Employee>();
            JoeList2 = employeeList.Where(x => x.firstName == "Joe").ToList();
            JoeList2.ForEach(i => Console.WriteLine("{0} {1} {2}\t", i.firstName, i.lastName, i.ID));

            Console.WriteLine("Here is the list of employees with an ID greater than 5:");

            List<Employee> IDList = new List<Employee>();
            IDList = employeeList.Where(x => x.ID > 5).ToList();
            IDList.ForEach(j => Console.WriteLine("{0} {1} {2}\t", j.firstName, j.lastName, j.ID));

            Console.ReadLine();
        }
    }
}

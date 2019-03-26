using System;

namespace _129ExerciseOperatorOverlaod
{
    public class Employee : Person
    {
        public int ID { get; set; }

        //creates the operator overload to use == or != to check if emploee1 and employee2 have equal id values
        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.ID != employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override void SayName()
        {
            Console.WriteLine("SayName worked inside the Employee class");
        }

        public void SayName(string food)
        {
            Console.WriteLine("This employees favorite food is: "+food);
        }
        public void Quit()
        {
            Console.WriteLine("Method Quit has been implemented.");
        }
    }
}

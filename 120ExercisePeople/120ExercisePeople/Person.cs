using System;

namespace _120ExercisePeople
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            //string FirstName = "";
            //string LastName = "";
            //string fName = FirstName;
            //throw new NotImplementedException();
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

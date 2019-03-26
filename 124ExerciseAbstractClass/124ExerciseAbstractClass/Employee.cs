using System;

namespace _124ExerciseAbstractClass
{
    public class Employee : Person
    {
        //What does it mean to implement the SayName method here?
        public override void SayName()
        {
            Console.WriteLine("SayName worked inside the Employee class");
        }
    }
}

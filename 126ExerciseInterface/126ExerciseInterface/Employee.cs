using System;

namespace _126ExerciseInterface
{
    public class Employee : Person, IQuittable
    {
        //What does it mean to implement the SayName method here?
        public override void SayName()
        {
            Console.WriteLine("SayName worked inside the Employee class");
        }
        public void Quit()
        {
            Console.WriteLine("Method Quit has been implemented.");
        }
    }
}

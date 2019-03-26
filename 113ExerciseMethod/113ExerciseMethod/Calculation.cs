using System;

namespace _113ExerciseMethod
{
    partial class Program
    {
        public class Calculation
        {
            //variable from Program.cs is now variable num1 with int data type.
            //int Add() defines the data type that will be returned from this method Add
            public void Add(int num1, int num2)
            {
                num1 = num1 + 10;
                Console.WriteLine("The first number plus ten is: " + num1);
                Console.WriteLine("The second number is: " + num2);
            }            
        }
    }
}

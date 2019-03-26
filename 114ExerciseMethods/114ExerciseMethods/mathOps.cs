using System;

namespace _114ExerciseMethods
{
    partial class Program
    {
        public class mathOps
        {
            public int Add(int num1)
            {
                num1 = num1 + 47;
                return num1;
            }
            public int Add(decimal num1)
            {
                num1 = num1 + 773.91238746M;
                return Convert.ToInt32(num1);
            }
            public int Add(string num1)
            {
                try
                {
                    int num2 = Convert.ToInt32(num1);
                    num2 = num2 + 144;
                    return num2;
                } catch (FormatException)
                {
                    Console.WriteLine("Input cannot be converted to int data type.");
                }
                return 0;
            }
        }
    }
}

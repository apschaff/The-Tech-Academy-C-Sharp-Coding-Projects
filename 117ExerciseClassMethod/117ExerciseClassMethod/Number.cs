namespace _117ExerciseClassMethod
{
    partial class Program
    {
        public class Number
        {
            public void Divide(out int num2, int num1 = 5)
            {
                num2 = num1 / 2;
            }

            public int Add(int num1)
            {
                num1 = num1 + 5;                
                return num1;
            }

            public double Add(double num1 = 18)
            {
                num1 = num1 + 10.2;
                return num1;
            }
        }
    }
}

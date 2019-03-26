using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137ExerciseStruct
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 77;
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}

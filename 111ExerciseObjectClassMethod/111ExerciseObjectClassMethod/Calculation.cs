using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111ExerciseObjectClassMethod
{
    public class Calculation
    {        
        //variable from Program.cs is now variable num1 with int data type.
        //int Add() defines the data type that will be returned from this method Add
        public int Add(int num1)
        {
            num1 = num1 + 10;
            return num1;
        }
        public int Subtract(int num2)
        {
            num2 = num2 - 2;
            return num2;
        }
        public int Multiply(int num3)
        {
            num3 = num3 * 5;
            return num3;
        }
    }
}

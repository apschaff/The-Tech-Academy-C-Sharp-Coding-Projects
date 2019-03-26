using System;
using System.Collections.Generic;

namespace _106ExerciseExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numerators = new List<int> { 892, 88, 12, 900, 1002, 450, 444, 23 };
            Console.WriteLine("Please enter a number to divide the list numbers by.");

            try
            {
                // with input of string value, recieved exception: System.FormatException: 'Input string was not in a correct format.'
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int numerator in numerators)
                {
                    // with input of 0, recieved exception: System.DivideByZeroException: 'Attempted to divide by zero.'                
                    int quotient = numerator / divisor;
                    Console.WriteLine(numerator + " divided by " + divisor + " equals " + quotient);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Letters are not allowed. Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero. Please use a nonzero number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }            
        }
    }
}

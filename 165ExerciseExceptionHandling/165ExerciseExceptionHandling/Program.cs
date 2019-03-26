using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _165ExerciseExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new NegativeException();
                }
                if (userAge == 0)
                {
                    throw new ZeroException();
                }

                userAge = userAge * -1;
                DateTime currentTime = DateTime.Now;
                DateTime birthYear = currentTime.AddYears(userAge);
                Console.WriteLine("You were born in {0} or {1}", birthYear.Year - 1, birthYear.Year);
            }
            catch (NegativeException)
            {
                Console.WriteLine("You must enter a positive age. A negative age is not possible.");
                Console.ReadLine();
                return;
            }
            catch (ZeroException)
            {
                Console.WriteLine("This program is restricted for those under the age of one. Please enter an age greater than 0.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Your input could not be processed. Please enter a whole number.");
                Console.ReadLine();
                return;
            }            
            Console.Read();
        }
    }
}

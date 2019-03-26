using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100ExerciseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Hello ", "there ", "are ", "a ", "variety ", "of ", "string", "values ", "within ", "this ", "Array " };
            Console.WriteLine("Please choose an index from the string array.");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            if (stringIndex < 11) //Is there a way to look and see if an index position exists? 
            {
                Console.WriteLine("The value is: " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Sorry, this index value does not exist.");
            }

            int[] intArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine("Please choose an index from the number array.");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            if (intIndex < 12)
            {
                Console.WriteLine("The value is: " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Sorry, this index value does not exist.");
            }

            List<string> stringList = new List<string>();
            stringList.Add("Welcome ");
            stringList.Add("these ");
            stringList.Add("words ");
            stringList.Add("are ");
            stringList.Add("a ");
            stringList.Add("part ");
            stringList.Add("of ");
            stringList.Add("my ");
            stringList.Add("string ");
            stringList.Add("list.");

            Console.WriteLine("Please choose an index from the string list.");
            int sIndex = Convert.ToInt32(Console.ReadLine());
            if (sIndex < 10)
            {
                Console.WriteLine("The value is: " + stringList[sIndex]);
            }
            else
            {
                Console.WriteLine("Sorry, this index value does not exist.");
            }
            Console.ReadLine();
        }
    }
}

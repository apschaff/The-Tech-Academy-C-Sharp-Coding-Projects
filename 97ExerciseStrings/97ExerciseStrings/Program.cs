using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _97ExerciseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String my = "My ";
            string nis = "name is ";
            string name = "Andrew";
            string intro = my + nis + name;
            Console.WriteLine(intro);

            intro = intro.ToUpper();
            Console.WriteLine(intro);

            StringBuilder bacon = new StringBuilder("Spicy jalapeno bacon ipsum dolor amet bacon ball tip ut swine tempor pork belly consequat. ");
            bacon.Append("Jerky cupim sint ad, pig rump jowl buffalo fatback strip steak sausage. ");
            bacon.Append("Sed qui ham porchetta filet mignon in quis consequat tail ribeye sirloin fatback. ");
            bacon.Append("Meatball burgdoggen pork loin sausage.");
            Console.WriteLine(bacon);
            Console.ReadLine();
        }
    }
}

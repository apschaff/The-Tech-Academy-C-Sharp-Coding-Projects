using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic74
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            //OR
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            //EQUAL
            Console.WriteLine(true == false);
            Console.WriteLine(true == true);
            Console.WriteLine(false == false);

            //NOT EQUAL
            Console.WriteLine(true != false);
            Console.WriteLine(true != true);
            Console.WriteLine(false != false);

            //XOR
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);


            Console.ReadLine();
        }
    }
}

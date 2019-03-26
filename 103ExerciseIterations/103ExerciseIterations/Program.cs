using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //1
        string[] fruits = new string[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter a fruit: ");
            fruits[i] = Console.ReadLine();
        }
        Console.WriteLine("The fruits you entered are:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(fruits[i]);
        }
        Console.ReadLine();

        //2
        //int apple = 0;
        //for (int j = 0; apple == 0; j++)
        //{
        //    Console.WriteLine("Apple");
        //};
        //Console.ReadLine();

        //3
        for (int j = 0; j != 5; j++)
        {
            Console.WriteLine("Apple");
        };
        Console.ReadLine();

        //4
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine("Apple");
        };
        Console.ReadLine();

        //5
        for (int j = 0; j <= 5; j++)
        {
            Console.WriteLine("Apple");
        };
        Console.ReadLine();

        //6-8
        List<string> names = new List<string>() { "Jesse", "Eric", "Daniel", "Adam", "Jeremy", "Doug", "Allen", "Ernie", "Brittany", "Terry", "Lauren", "Rachel" };

        Console.WriteLine("Please type a search criteria for the listed names.");
        string search = Console.ReadLine();
        int m = 0;
        for (int n = 0; n < names.Count; n++)
        {
            string name = names[n].ToString();
            if (name.ToLower().Contains(search.ToLower()))
            {
                Console.WriteLine(name);
                break;
            }
            else
            {
                m++;
                if (m >= names.Count)
                {
                    Console.WriteLine("No matches were found.");
                }
            }
        }
        Console.ReadLine();

        //9-10
        List<string> names1 = new List<string>() { "Jesse", "Eric", "Daniel", "Rachel", "Jesse", "Daniel", "Allen", "Eric", "Brittany", "Terry", "Lauren", "Rachel" };

        Console.WriteLine("Please type a search criteria for the listed names.");
        string search1 = Console.ReadLine();
        int k = 0;
        for (int h = 0; h < names1.Count; h++)
        {
            string name1 = names1[h].ToString();
            if (name1.ToLower().Contains(search1.ToLower()))
            {
                Console.WriteLine(Convert.ToString(h));
            }
            else
            {
                k++;
                if (k >= names1.Count)
                {
                    Console.WriteLine("No matches were found.");
                }
            }
        }
        Console.ReadLine();

        //11
        List<string> names2 = new List<string>() { "Jesse", "Eric", "Daniel", "Rachel", "Jesse", "David", "Allen", "Eric", "Brittany", "Terry", "Lauren", "Ramon" };
        int p = -1;

        foreach (string name2 in names2)
        {
            string nameCompare = name2;
            p++;            
            //Console.WriteLine(p);
            Console.WriteLine(name2);
            for (int q = 0; q < p; q++)
            {
                //Console.WriteLine("Name: " + names2[q] + q);

                if (nameCompare == names2[q])
                {
                    Console.WriteLine("This name is a duplicate: " + nameCompare);
                    break;
                }
            }
        }        
        Console.ReadLine();
    }
}

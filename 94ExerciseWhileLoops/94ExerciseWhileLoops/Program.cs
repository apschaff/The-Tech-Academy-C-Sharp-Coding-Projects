using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94ExerciseWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What state was Abraham Lincoln born in?");
            string state = Console.ReadLine();
            bool correct = state == "kentucky" || state == "Kentucky";
            int m = 0;

            do
            {
                if (state == "kentucky" || state == "Kentucky")
                {
                    Console.WriteLine("Congratulations! You are correct!");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry! You guessed " + state + ". That is incorrect.");
                    Console.WriteLine("Please try again.");
                    state = Console.ReadLine();
                    m++;
                }
                if (m == 2)
                {
                    Console.WriteLine("Sorry, you ran out of guesses. The correct answer is Kentucky.");
                    Console.ReadLine();
                    break;
                }
            }
            while (!correct);



            Console.WriteLine("What is the most popular truck model in the United States?");
            int n = 0;
            string truck = "0";
            bool correctTruck = truck == "F-150" || truck == "F150";
                        
            while (!correctTruck)
            {
                Console.WriteLine("Please enter your answer.");
                truck = Console.ReadLine();
                //Console.WriteLine(n);
                n++;
                switch (truck)
                {
                    case "Silverado":
                        Console.WriteLine("Close, the Silverado is the second best selling truck in the United States");
                        break;
                    case "Tundra":
                        Console.WriteLine("Sorry, The Tundra is a great truck, but it is far from the best selling truck in the United States");
                        break;
                    case "Ram":
                        Console.WriteLine("Sorry, The Ram is probably the most comfortable truck, but it is not the best selling truck in the United States");
                        break;
                    case "Tacoma":
                        Console.WriteLine("Sorry, The Tacoma is very popular, but it is not the bestselling truck in the United States");
                        break;
                    case "Titan":
                        Console.WriteLine("Sorry, The Titan is not the bestselling truck in the United States and for good reason");
                        break;
                    case "F-150":
                        Console.WriteLine("You said: " + truck + ". That is correct!");
                        correctTruck = true;
                        break;
                    case "F150":
                        Console.WriteLine("You said: " + truck + ". That is correct!");
                        correctTruck = true;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You guessed: " + truck + ". That is incorrect.");
                        break;
                }
                if (n == 3)
                {
                    Console.WriteLine("Sorry, you ran out of guesses. The correct answer is F-150.");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}

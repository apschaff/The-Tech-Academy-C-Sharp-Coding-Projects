using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        //should I inherit something or include it as a class property.
        //If it has something, include it as a class property. if it is something, inherit it. 
        //If you are unsure, put it in as a property
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Andrew\Programming\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}

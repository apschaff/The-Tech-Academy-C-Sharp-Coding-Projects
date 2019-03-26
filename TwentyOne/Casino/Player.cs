using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //call constructor
        public Player(string name): this(name, 100)
        {
        }
        //this is a constructor that takes two arguments and takes those arguments and assigns them to properties in the class
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }

        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place that size bet.");
                return false;
            }
            else
            {
                Balance -= amount; //same as Balance = Balance - amount
                return true;
            }
        }

        public static Game operator +(Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}

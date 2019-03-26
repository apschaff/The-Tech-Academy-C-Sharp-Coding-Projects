using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //Abstract because we will never have an instance of game. This makes it a base class or abstract class.
    public abstract class Game
    {
        //Game.players is a list. any time you are working with a list you will have this problem. In order to fix this you need to instantiate a list. The two lines below are the same a s a regular { get; set; } but here players equals an empty list if it is not set. This is a good practice.
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set { _players = value; } }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public string Name { get; set; }

        //we can't specify the "play" implementation in the base class. we want every game to have a method called play. to do this we add an abstract method
        //This requires the Play method to be defined in each class.
        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}

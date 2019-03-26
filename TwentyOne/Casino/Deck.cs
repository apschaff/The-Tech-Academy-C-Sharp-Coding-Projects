using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        //inside the class this constructor (public Deck()) is a method that's called as soon as an object is created
        public Deck()
        {
            //The first thing the constructor does is instantiate its property (Cards) as an empty list because a list must be created before it can be filled.
            //"Cards" below refers to the property of the class. That's why we don't need to put a data type before it to give it a variable name. 
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        //public: want it accessible everywhere
        //static: dont want to have to create an object before calling this
        //Deck: type of data it is returning
        //Shuffle: the name of the function. that's what it's returning.
        //Deck deck: parameter of type Deck and variable deck that we can refer to.
        //int times = 1: gives a default paramter making this value optional.
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                //Temporary list where we will store our shuffled cards
                List<Card> TempList = new List<Card>();
                //Random class (part of C# Framework Library) helps us create as close to random results as possible. has methods connected to it.  random
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    //Add it to temporary list randomly (randomIndex)
                    TempList.Add(Cards[randomIndex]);
                    //Remove it from the temporary list randomly (randomIndex)
                    Cards.RemoveAt(randomIndex);
                }
                //this. jut means it is referring to itself as the object. not necessary.
                this.Cards = TempList;
            }
        }
    }
}

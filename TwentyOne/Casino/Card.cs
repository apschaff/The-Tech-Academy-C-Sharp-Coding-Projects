using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //card is a valid struct because nothing is inheriting from card
    public struct Card
    {
        //the object card now has a property "Suit"
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        // Evert class has a built in method that is a ToString method. for custom objects this can be a problem but this is how we override it. This is a custom ToString Method
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}

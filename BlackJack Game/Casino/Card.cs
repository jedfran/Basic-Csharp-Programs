using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        //List of Properties
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        //Overriding ToString Method
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    //Defining enum of the cards
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

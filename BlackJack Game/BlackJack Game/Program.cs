using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Instantiating Deck Class
            Deck deck = new Deck();
            //Shuffles Deck 3 times
            deck.Shuffle(3);

            //Prints the Suit and Face of the Card 
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            //Shows the card count (52)
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

        }

    }
}

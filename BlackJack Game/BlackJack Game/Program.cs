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

            Deck deck = new Deck();
            deck = Shuffle(deck); //comment this code to have the deck unshuffled
           
            foreach (Card card in deck.Cards)
                {
                Console.WriteLine(card.Face + " of " + card.Suit);
                }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            }

        //Shuffling the deck in random order
        public static Deck Shuffle(Deck deck)
            {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
                {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
                }

            deck.Cards = tempList;
            return deck;
            }
        }
    }

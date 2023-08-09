using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack_Game
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //adding the card to hand
            //Logging
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //disposing string
            using (StreamWriter file = new StreamWriter(@"C:\Users\Jedo Francisco\logs\log.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}

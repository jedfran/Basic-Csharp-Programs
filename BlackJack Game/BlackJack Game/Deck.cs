using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game
{
    public class Deck
    {

        public Deck()
        {
            Cards = new List<Card>();
            //List of Suits
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamonds" };
            //List of Faces
            List<string> Faces = new List<string>()
                {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Jack", "Queen", "King", "Ace"
                };

            //Nested For Loops
            foreach (string face in Faces)
            {
                //Loop to get all 52 cards without having to write it all down
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        //Shuffling the deck in random order
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {

                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]); //Adds the card into the tempList (shuffled)
                    Cards.RemoveAt(randomIndex); //After card is added, the index (0) is removed which is the top of the stack
                }

                //Changes the Cards(unshuffled) to the value of tempList(shuffled)
                Cards = tempList;
            }

        }


    }
}

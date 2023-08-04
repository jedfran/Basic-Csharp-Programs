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
            //for loop for the Faces of the Cards
            for(int i = 0; i<13; i++)
            {
                //for loop for each Suit of the Cards
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //first face is j=0 so "Two"
                    card.Suit = (Suit)j; //first suit is i=0 so "Spades"
                    Cards.Add(card); //Adds the card into the "Cards" List
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

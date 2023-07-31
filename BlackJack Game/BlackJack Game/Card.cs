using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game
    {
    public class Card
        {
        //Constructor
        public Card()
            {
            Suit = "Spades";
            Face = "Two"; 
            }
        public string Suit { get; set; }
        public string Face { get; set; }

        }
    }

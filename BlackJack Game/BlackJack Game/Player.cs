using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game
{
    public class Player
    {

        // List of Properties
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }


        // Overloaded Operator Method

        //Overloading the plus operator (+)
        public static Game operator+ (Game game, Player player) //In the parameters are what we are adding together
        {
            game.Players.Add(player);
            return game;
        }

        //Overloading the minus operator (-)
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}

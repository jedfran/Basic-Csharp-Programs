using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Player
    {
        //Constructor 
        public Player(string name, int beginningBalance) //takes 2 parameters
        {
            //initializing list so we can add things to them
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        //Initianting List
        private List<Card> _hand = new List<Card>();

        // List of Properties
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        //Global Unique Identifier
        public Guid Id { get; set; }

        //Bet Method
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


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

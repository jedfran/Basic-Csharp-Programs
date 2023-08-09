using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.BlackJack;

namespace BlackJack_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money do you plan on spending today?");
            int playerBal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of BlackJack right now?", playerName) ;
            string answer = Console.ReadLine().ToLower(); //lowercasing user's answer
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //new object of player
                Player player = new Player(playerName, playerBal);
                Game game = new TwentyOneGame(); //polymorphism
                game += player; //added player to the game using overloaded operators
                player.isActivelyPlaying = true; //used for while loop (While this is true, keep playing)
                
                //while loop keeps going until player wants to stop or they run out of money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to explore around the Grand Hotel and Casino. Bye for now!");
            Console.Read();
        }

    }
}

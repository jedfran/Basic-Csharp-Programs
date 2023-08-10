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

            //Exception Handling
            bool validAnswer = false;
            int playerBal = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out playerBal);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }
            Console.WriteLine("Hello, {0}. Would you like to join a game of BlackJack right now?", playerName) ;
            string answer = Console.ReadLine().ToLower(); //lowercasing user's answer
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                //new object of player
                Player player = new Player(playerName, playerBal);
                //Using GUID
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Jedo Francisco\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame(); //polymorphism
                game += player; //added player to the game using overloaded operators
                player.isActivelyPlaying = true; //used for while loop (While this is true, keep playing)
                
                //while loop keeps going until player wants to stop or they run out of money
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("SECURITY!!! Kick this person out!");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to explore around the Grand Hotel and Casino. Bye for now!");
            Console.Read();
        }

    }
}

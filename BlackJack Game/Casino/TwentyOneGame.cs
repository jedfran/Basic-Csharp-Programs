using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.BlackJack
{
    public class TwentyOneGame : Game, IWalkAway // :Game inherits the from the class Game and inherits from inteface "IWalkAway"
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players) //Players is a property of the Game Class
            {
                player.Hand = new List<Card>(); //Reset the player's cards
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); //Resets the dealer's cards 
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //Resets dealers deck
            //Shuffling Deck
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bets!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
                }
                if (bet<0)
                {
                    throw new FraudException();
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet) //same thing as (successfullyBet == false) 
                {
                    return;
                }
                //dictionary entry
                Bets[player] = bet;
            }

            //Dealing 2 cards to each players using for loops
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}:", player.Name);
                    Dealer.Deal(player.Hand);
                    //Player wins blackjack
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);//Gets winning price and their bets back
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                //Dealer wins blackjack
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Deadler has Blackjack! Everyone loses");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            //Hit or Stay each player
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break; //checks if while loop is still true, which is false (player.Stay == true)
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand); //user gets a dealt a card 
                    }
                    //checks if player is busted
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        //if busted, dealer gets players bets
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}", player.Name, Bets[player], player.Balance);
                        //checks if player wants to keep playing
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "ya")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }

                    }
                }
            }
            //Checks if Dealer is busted and if they are staying
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            //If both are true Dealer hits
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand); //Dealers gets a card
                //if any of isBusted or Stay is true, while loop breaks
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //checks if dealer got busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is Busted!");
                //Each players get their winnings
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0}, won {1}!", entry.Key.Name, entry.Value);
                    //finding the player's name that is matching with the winnner's name and adding their winnings
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            //COMPARING VALUES of players' hand and dealers' hand
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("PUSH, No one wins!");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else 
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Do you wanna play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }

        }
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome 21 Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.BlackJack;
using System.Data.SqlClient;
using System.Data;

namespace BlackJack_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            //Command that prints out a log of exceptions
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.ID + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
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
                    catch(FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWtihException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator");
                        UpdateDbWtihException(ex);
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

        //Logging Exceptions Method
        private static void UpdateDbWtihException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = BlackJackGame;
                                      Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                      TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                      MultiSubnetFailover = False";

            //Query string
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                   (@ExceptionType, @ExceptionMessage, @TimeStamp)";
                

            //Parameterized queries to avoid SQL injection attacks
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                //Sending to DataBase
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = BlackJackGame;
                                      Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                      TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                      MultiSubnetFailover = False";


            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.ID = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);

                    Exceptions.Add(exception);
                }
                connection.Close();

            }
            return Exceptions;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Game
{
    public abstract class Game
    {
        //Instantiating List
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();


        // List of Properties
        public List<Player> Players { get { return _players; } set { _players = value; }}
        public string Name { get; set; }
        public abstract void Play();
        //Dictionary property, a dictionary takes key and value
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }


}

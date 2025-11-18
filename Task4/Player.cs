using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Player
    {
        public string playerName;
        public int level;
        public int health;

        // Default constructor
        public Player()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor
        public Player(string playerName, int level, int health)
        {
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }
    }

}
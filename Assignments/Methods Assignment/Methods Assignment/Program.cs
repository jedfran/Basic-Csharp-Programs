using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("You encountered a monster in the bushes! It goes for an attack");
            Console.WriteLine("Enter your defense stats: ");
            int defense = Convert.ToInt32(Console.ReadLine());
            //Defense Method
            int enemy_dmg = MathOperation.Defense(defense);
            Console.WriteLine("You have taken " + enemy_dmg + " amount of damage!");

            Console.WriteLine("You go for a counter attack!");
            Console.WriteLine("Enter your attack stats: ");
            int attack = Convert.ToInt32(Console.ReadLine());
            //Attack Method
            int counter_attack = MathOperation.Attack(attack);
            Console.WriteLine("You successfuly landed your blow dealing " + counter_attack + "HP to the monster!");


            Console.WriteLine("You killed the monster!");
            Console.WriteLine("Your mage tends your wounds with healing magic");
            Console.WriteLine("Enter healer's magic stats:");
            int heal = Convert.ToInt32(Console.ReadLine());
            //Healing Method
            int healing = MathOperation.Heal(heal);
            Console.WriteLine("Your HP goes up by " + healing + "HP! Thanks to your mage.");

            Console.ReadLine();

            }
        }
    }

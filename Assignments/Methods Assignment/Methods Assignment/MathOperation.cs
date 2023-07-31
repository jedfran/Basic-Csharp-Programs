using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Assignment
    {
    class MathOperation
        {

        // 3 Methods that take integer parmeter and return an integer

        //Healing Method
        public static int Heal(int heal)
            {
            int health = heal + 5;
            return health;
            }

        //Defense Method
        public static int Defense(int defense)
            {
            int enemy_str = 10;
            int weapon_dmg = 7;
            int damage = (enemy_str + weapon_dmg) - defense;
            return damage;
            }

        //Attack Method
        public static int Attack(int attack)
            {
            int enemy_def = 6;
            int weapon_dmg = 10;
            int damage = (attack + weapon_dmg) - enemy_def;
            return damage;
            }

        }
    }

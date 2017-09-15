using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CombatSystem
{
    class Style
    {
        public static string BattleStance(string input)
        {
            Random rnd = new Random();
            int style = 0;
            if (input == "Dragon")
            style = rnd.Next(1, 4);  // 1 agressive-> 2 standard ->3defensive->
            if (input == "1")
                style = 1;
            if (input == "2")
                style = 2;
            if (input == "3")
                style = 3;


            if (style == 1)
                return "Agressive";
            if (style == 2)
                return "Standard";
            if (style == 3)
                return "Defensive";
            else
                return null;
        }

        public static int StyleSwitch(string attacker, string defender)
        {
            string decider = (attacker + defender);

            if (decider == "AgressiveAgressive")
                return 1;
            if (decider == "StandardStandard")
                return 1;
            if (decider == "DefensiveDefensive")
                return 1;

            if (decider == "AgressiveStandard")
                return 3;
            if (decider == "DefensiveAgressive")
                return 3;
            if (decider == "StandardDefensive")
                return 3;


            if (decider == "AgressiveDefensive")
                return 0;
            if (decider == "DefensiveStandard")
                return 0;
            if (decider == "StandardAgressive")
                return 0;
            else
                return 0;


        }

        public static int Damage(int styleIncrease)
        {
            Console.Clear();
            Random rnd = new Random();
            int damage = rnd.Next(1, 7);
            damage = damage * styleIncrease;
            if (damage > 13)
                Console.WriteLine("Ouch, " + damage +"damage! It was a critical strike!");
            if (damage > 9 && damage < 14)
                Console.WriteLine(damage +"damage! It was a solid strike!");
            if (damage > 5 && damage < 10)
                Console.WriteLine(damage + "damage! It's just a flesh wound!");
            if (damage > 0 && damage < 6)
                Console.WriteLine(damage + "damage! It was a Glancing blow!");
            if (damage == 0)
                Console.WriteLine(damage + "damage! The Dragon Missed");

                return damage;
        }
    }
}

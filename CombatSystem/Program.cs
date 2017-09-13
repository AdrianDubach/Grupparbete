using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CombatSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int lifeDragon = 100;
            int lifeKnight = 100;
            int damage;
            while (lifeDragon > 0 || lifeKnight > 0)
            {
                Style combat = new Style();
                string knightStyle = Style.BattleStance();

                Console.WriteLine("Knights stance is " + knightStyle);

                string dragonStyle = Style.BattleStance();
                Console.WriteLine("Dragons stance is " + dragonStyle);
                Console.WriteLine();
                Console.WriteLine("The Knight attacks!");

                damage = Style.Damage(Style.StyleSwitch(knightStyle, dragonStyle));
                lifeDragon = Life.DamageDone(damage, lifeDragon);
                Console.WriteLine("Dragon has " + lifeDragon + " life remaining");
                if (lifeDragon <= 75 && lifeDragon >= 51)
                    Console.WriteLine("Foolish human, I will burn you alive!");

                if (lifeDragon <= 50 && lifeDragon >= 26)
                    Console.WriteLine("GRARARRRARARAR, YOU ANGER ME!");

                if (lifeDragon <= 25 && lifeDragon >= 0)
                    Console.WriteLine(".... WHAT IS THIS!?!");
                Console.WriteLine();
                Console.WriteLine("The Dragon attacks!");

                damage = Style.Damage(Style.StyleSwitch(dragonStyle, knightStyle));
                lifeKnight = Life.DamageDone(damage, lifeKnight);
                Console.WriteLine("Knight has " + lifeKnight + " life remaining");
                Console.WriteLine();

                if (lifeKnight <= 0)
                {
                    Console.WriteLine("The knight got crushed, stomped and devoured by the Dragon");
                    break;
                }


                if (lifeDragon <= 0)
                {
                    Console.WriteLine("The knight bested the Dragon!");
                    break;
                }
            }
            //Console.WriteLine(styleResult);
            Console.Read();


        }
    }
}

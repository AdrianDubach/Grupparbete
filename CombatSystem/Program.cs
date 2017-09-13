using System;
using System.Collections.Generic;
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
                //string knightStyle = Style.BattleStance();

                //Console.WriteLine("Knights stance is " + knightStyle);

                string dragonStyle = Style.BattleStance("Dragon");
                if (dragonStyle == "Agressive")
                    Console.WriteLine("The Dragon Looks agressive");
                if (dragonStyle == "Standard")
                    Console.WriteLine("The Dragon looks calculative");
                    if (dragonStyle == "Defensive")
                    Console.WriteLine("The Dragon looks startled");


                        Console.WriteLine("choose what to do! Dodge(1) Run(2) Defend with shield(3)");
                string knightStyle = Style.BattleStance(Console.ReadLine());

                //damage = Style.Damage(Style.StyleSwitch(knightStyle, dragonStyle));
                //lifeDragon = Life.DamageDone(damage, lifeDragon);
                //Console.WriteLine("Dragon has " + lifeDragon + " life remaining");
                //if (lifeDragon <= 75 && lifeDragon >= 51)
                //    Console.WriteLine("Foolish human, I will burn you alive!");

                //if (lifeDragon <= 50 && lifeDragon >= 26)
                //    Console.WriteLine("GRARARRRARARAR, YOU ANGER ME!");

                //if (lifeDragon <= 25 && lifeDragon >= 0)
                //    Console.WriteLine(".... WHAT IS THIS!?!");
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

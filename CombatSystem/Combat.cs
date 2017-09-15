using System;
using System.Collections.Generic;
using System.Text;

namespace CombatSystem
{
    class Combat
    {
        public static int Drakfight()
        {
            int lifeKnight = 0;
            int damage;

            Style combat = new Style();
            string dragonStyle = Style.BattleStance("Dragon");
            if (dragonStyle == "Agressive")
                Console.WriteLine("The Dragon Looks agressive");
            if (dragonStyle == "Standard")
                Console.WriteLine("The Dragon looks calculative");
            if (dragonStyle == "Defensive")
                Console.WriteLine("The Dragon looks startled");


            Console.WriteLine("choose what to do! Dodge(1) Run(2) Defend with shield(3)");
            string knightStyle = Style.BattleStance(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("The Dragon attacks!");

            damage = Style.Damage(Style.StyleSwitch(dragonStyle, knightStyle));
            lifeKnight = Life.DamageDone(damage, lifeKnight);
            Console.WriteLine("Knight lost " + lifeKnight + " life");
            Console.WriteLine();


            if (lifeKnight <= 0)
            {
                Console.WriteLine("The knight got crushed, stomped and devoured by the Dragon");
                return lifeKnight;
            }
            return lifeKnight;

        }
    }
}

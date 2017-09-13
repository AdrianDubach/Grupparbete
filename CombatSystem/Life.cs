using System;
using System.Collections.Generic;
using System.Text;

namespace CombatSystem
{
    class Life
    {
        public static int DamageDone(int damage, int life)
        {
            int returnLife = life - damage;
            return returnLife;



        }
        
    }
}


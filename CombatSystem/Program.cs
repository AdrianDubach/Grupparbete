using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CombatSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {    /* här försöker jag typ simulera vad som skulle hända
               vad som skulle hända om man går in i en array ruta
               där draken finns*/
            ArrayGameboard.MetoderOchArrays play = new ArrayGameboard.MetoderOchArrays();

            int life = 100;
              life =   ArrayGameboard.MetoderOchArrays.GameBoard();

            if (life <= 0)
                Console.WriteLine("You diedededed");
            if (life >= 0)
                Console.WriteLine("you're even alive!");

            Console.Read();


        }
    }
}


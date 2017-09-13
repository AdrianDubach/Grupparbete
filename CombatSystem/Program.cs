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
            Combat fight = new Combat();
            bool attacked = false;
            int test;
            Console.WriteLine("press 1 to start an engagement");
            test = int.Parse(Console.ReadLine());

            if (test == 1)
                attacked = true;

            if(attacked == true)
            Combat.Drakfight();

            Console.Read();


        }
    }
}

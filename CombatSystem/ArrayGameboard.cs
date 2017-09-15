using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayGameboard
{
    class MetoderOchArrays
    {
        public static int GameBoard()
        {
            int[,] board = new int[10, 10];
            string input = null;
            int playerX = 0;
            int playerY = 0;
            Random rnd = new Random();

            for (int i = 0; i <= 25; i++)
            {
                int random = rnd.Next(1, 9);
                int random2 = rnd.Next(1, 9);
                if (board[random, random2] < 2)
                    board[random, random2] = 2;
                else
                    if (board[random + 1, random2] < 2)
                {
                    board[random + 1, random2] = 2;
                }
                else
                    if (board[random, random2 + 1] < 2)
                {
                    board[random, random2 + 1] = 2;
                }
            }
            int rand = rnd.Next(0, 9);
            int rand2 = rnd.Next(0, 9);
            board[rand, rand2] = 4;


            int life = 10;
            while (input != "stop"|| life <= 0)
            {
                
                int playerLocation = 1;
                int random = rnd.Next(0, 9);
                int random2 = rnd.Next(0, 9);
                if (playerLocation == 4)
                {
                    Console.WriteLine("you made it!");
                    break;
                }
                Console.WriteLine("Knight has "+life+" life remaining");
                Console.WriteLine("please make a move. W = up. S = down. A = left. D = right");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "s")
                {
                    if (playerY < 9)
                    {
                        playerY++;
                    }
                    if (playerY == 9 || playerY == 0)
                        Console.WriteLine("You reached southern wall");

                }
                if (input == "w")
                {
                    if (playerY > 0)
                    {
                        playerY--;
                    }
                    if (playerY == 9 || playerY == 0)
                        Console.WriteLine("You reached northern wall");

                }
                if (input == "a")
                {
                    if (playerX > 0)
                    {
                        playerX--;
                    }
                    if (playerX == 9 || playerX == 0)
                        Console.WriteLine("You reached western wall");

                }
                if (input == "d")
                {
                    if (playerX < 9)
                    {
                        playerX++;
                    }
                    if (playerX == 9 || playerX == 0)
                        Console.WriteLine("You reached eastern wall");
                }





                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (board[i, j] == 1)
                            board[i, j] = 0;

                        if (board[i, j] == 2)
                            board[i, j] = 2;


                    }

                }
                if (board[playerY, playerX] == 2)
                { //kalla drakfight metod
                   life = life + CombatSystem.Combat.Drakfight();
                    if (life <= 0)
                        break;
                   
                    board[playerY, playerX] = 3;
                    playerLocation = board[playerY, playerX];
                    
                }
                if (board[playerY, playerX] == 4)
                {
                    board[playerY, playerX] = 4;
                    playerLocation = board[playerY, playerX];
                    Console.WriteLine("you made it");
                    
                    return life;
                }
                
                else
                    board[playerY, playerX] = playerLocation;
                Console.WriteLine("" + board[0, 0] + "" + board[0, 1] + "" + board[0, 2] + "" + board[0, 3] + "" + board[0, 4] + "" + board[0, 5] + "" + board[0, 6] + "" + board[0, 7] + "" + board[0, 8] + "" + board[0, 9]);
                Console.WriteLine("" + board[1, 0] + "" + board[1, 1] + "" + board[1, 2] + "" + board[1, 3] + "" + board[1, 4] + "" + board[1, 5] + "" + board[1, 6] + "" + board[1, 7] + "" + board[1, 8] + "" + board[1, 9]);
                Console.WriteLine("" + board[2, 0] + "" + board[2, 1] + "" + board[2, 2] + "" + board[2, 3] + "" + board[2, 4] + "" + board[2, 5] + "" + board[2, 6] + "" + board[2, 7] + "" + board[2, 8] + "" + board[2, 9]);
                Console.WriteLine("" + board[3, 0] + "" + board[3, 1] + "" + board[3, 2] + "" + board[3, 3] + "" + board[3, 4] + "" + board[3, 5] + "" + board[3, 6] + "" + board[3, 7] + "" + board[3, 8] + "" + board[3, 9]);
                Console.WriteLine("" + board[4, 0] + "" + board[4, 1] + "" + board[4, 2] + "" + board[4, 3] + "" + board[4, 4] + "" + board[4, 5] + "" + board[4, 6] + "" + board[4, 7] + "" + board[4, 8] + "" + board[4, 9]);
                Console.WriteLine("" + board[5, 0] + "" + board[5, 1] + "" + board[5, 2] + "" + board[5, 3] + "" + board[5, 4] + "" + board[5, 5] + "" + board[5, 6] + "" + board[5, 7] + "" + board[5, 8] + "" + board[5, 9]);
                Console.WriteLine("" + board[6, 0] + "" + board[6, 1] + "" + board[6, 2] + "" + board[6, 3] + "" + board[6, 4] + "" + board[6, 5] + "" + board[6, 6] + "" + board[6, 7] + "" + board[6, 8] + "" + board[6, 9]);
                Console.WriteLine("" + board[7, 0] + "" + board[7, 1] + "" + board[7, 2] + "" + board[7, 3] + "" + board[7, 4] + "" + board[7, 5] + "" + board[7, 6] + "" + board[7, 7] + "" + board[7, 8] + "" + board[7, 9]);
                Console.WriteLine("" + board[8, 0] + "" + board[8, 1] + "" + board[8, 2] + "" + board[8, 3] + "" + board[8, 4] + "" + board[8, 5] + "" + board[8, 6] + "" + board[8, 7] + "" + board[8, 8] + "" + board[8, 9]);
                Console.WriteLine("" + board[9, 0] + "" + board[9, 1] + "" + board[9, 2] + "" + board[9, 3] + "" + board[9, 4] + "" + board[9, 5] + "" + board[9, 6] + "" + board[9, 7] + "" + board[9, 8] + "" + board[9, 9]);


            }
            return life;
        }
                    
    }
}
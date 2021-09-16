using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class DieShuffle
    {
        public static void Frequency()
        {
            int Player1 = 0;
            int Freq = 0;
            while (Player1 < 100)
            {
                Random random = new Random();
                int Dice = random.Next(1, 7);
                Freq++ ;
                Console.WriteLine("Its a" + " " + Dice);
                int RoughVar = Dice;
                Player1 = (Player1 + Dice);
                if (Player1 > 100)
                {
                    Player1 = -RoughVar;
                }
                Console.WriteLine("Position is" + " " + Player1);
                if (Player1 == 100)
                {
                    Console.WriteLine("Congragulation you won the Game!!!!!!!!");
                    Console.WriteLine("Dice shuffled"+" " +Freq +" " + "Times");
                }

                if (Player1 == 19)
                {
                    Player1 = 66;
                    Console.WriteLine("You Got Ladder. Your new Position is 66");
                }
                else if (Player1 == 32)
                {
                    Player1 = 53;
                    Console.WriteLine("You Got Ladder. Your new Position is 53");
                }
                else if (Player1 == 67)
                {
                    Player1 = 100;
                    Console.WriteLine("Congragulation ! You got ladder to 100");
                }
                else if (Player1 == 73)
                {
                    Player1 = 91;
                    Console.WriteLine("You Got Ladder. Your new Position is 91");
                }
                if (Player1 == 25)
                {
                    Player1 = 6;
                    Console.WriteLine("Its a Snake. Your new Position is 6");
                }
                else if (Player1 == 46)
                {
                    Player1 = 12;
                    Console.WriteLine("Its a Snake. Your new Position is 12");
                }
                else if (Player1 == 74)
                {
                    Player1 = 52;
                    Console.WriteLine("Its a Snake. Your new Position is 52");
                }
                else if (Player1 == 88)
                {
                    Player1 = 91;
                    Console.WriteLine("You Got Ladder. Your new Position is 76");
                }
            }
        }
    }
}
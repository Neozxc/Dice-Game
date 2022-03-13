using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a number " + enemyRandomNum);

                if (playerPoints > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                } else if (enemyRandomNum > playerPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("AI wins the round!");
                } else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now - Player: " + playerPoints + ". Enemy: " + enemyPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            } else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            } else
            {
                Console.WriteLine("Its a draw!");
            }


            Console.ReadKey();
            Console.ReadLine();
        }
    }
}

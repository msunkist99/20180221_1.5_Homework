using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180221_1._5_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "_20180221_1._5_Homework";

            Random random = new Random();
            const string computerName = "Computer";
            int rollValueOne = 0;
            int rollValueTwo = 0;
            int computerScore = 0;
            int yourScore = 0;

            Console.Write("Hello - please enter your name - ");
            string yourName = Console.ReadLine();

            while ((yourScore < 20) || (computerScore < 20))
            {
                if (yourScore < 20)
                {
                    // Using the $ - interpolated string
                    Console.Write($"{yourName} - hit return to roll the dice");
                    Console.ReadLine();
                    rollValueOne = RollTheDice(random);
                    rollValueTwo = RollTheDice(random);
                    yourScore += rollValueOne + rollValueTwo;
                    AnnounceTheRollResults(yourName, rollValueOne, rollValueTwo, yourScore);
                }

                if (computerScore < 20)
                {
                    rollValueOne = RollTheDice(random);
                    rollValueTwo = RollTheDice(random);
                    computerScore += rollValueOne + rollValueTwo;
                    AnnounceTheRollResults(computerName, rollValueOne, rollValueTwo, computerScore);
                }
            }

            if (yourScore == 20)
            {
                AnnounceTheWinner(yourName, yourScore);
            }
            else
            {
                AnnounceTheLoser(yourName, yourScore);
            }

            if (computerScore == 20)
            {
                AnnounceTheWinner(computerName, computerScore);
            }
            else
            {
                AnnounceTheLoser(computerName, computerScore);
            }

            Console.ReadLine();
        }

        private static int RollTheDice(Random random)
        {
            // possible values from rolling two six-sided die are 2-12
            int rollValue = random.Next(1, 6);

            return rollValue;
        }

        private static void AnnounceTheRollResults(string playerName, int playerRollValueOne, int playerRollValueTwo, int playerScore)
        {
            Console.WriteLine($"{playerName} rolled a {playerRollValueOne} and {playerRollValueTwo}");
            Console.WriteLine($"{playerName} current score - {playerScore}");
            Console.WriteLine();
        }

        private static void AnnounceTheWinner(string winnerName, int winnerScore)
        {
            Console.WriteLine($"{winnerName} wins with a total score of {winnerScore}");
        }

        private static void AnnounceTheLoser(string loserName, int loserScore)
        {
            Console.WriteLine($"** {loserName} loses with a total score of {loserScore}");
        }
    }
}

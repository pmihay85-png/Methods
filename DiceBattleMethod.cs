using System;
using System.ComponentModel.Design;

namespace DiceBattleMethod
{
    class RollDice
    {
        int number;
        public void RandomDiceRoll()
        {
            Random rand = new Random();
            number = rand.Next(1, 7); // Generates a random number between 1 and 6
            Console.WriteLine($"Generated Dice Number: {number}");
        }

        public void BattleRound(int playerRoll, int enemyRoll)
        {
            if (enemyRoll > playerRoll)
            {
                Console.WriteLine("Player 2 (enemy) wins!");
            }
            else if (playerRoll > enemyRoll)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        public static void Main()
        {
            RollDice rng = new RollDice();
           // rng.RandomDiceRoll();
            RollDice player1 = new RollDice(); player1.RandomDiceRoll();
            RollDice player2 = new RollDice(); player2.RandomDiceRoll();
            //player1.RandomDiceRoll();
            //player2.RandomDiceRoll();
            rng.BattleRound(player1.number, player2.number);
            Console.WriteLine("You have completed the battle round.");

        }



    }


}

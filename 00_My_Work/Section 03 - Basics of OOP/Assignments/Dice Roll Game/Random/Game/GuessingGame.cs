using Dice_Roll_Game.UserCommunication;

namespace Dice_Roll_Game.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            var diceDescription = _dice.Describe();
            Console.WriteLine(diceDescription);
            Console.WriteLine($"Dice rolled. Guess what number it shows. You have {InitialTries} tries.");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number: ");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong guess. Try again.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                ? "Congratulations, You won!"
                : "You lost :)";

            Console.WriteLine(message);
        }
    }
}


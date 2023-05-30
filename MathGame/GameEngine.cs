using MathGame.Models;

namespace MathGame;

public class GameEngine
{
    public void AdditionGame(string message)
    {
        Console.WriteLine(message);
        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} + {secondNumber}");
            string result = Console.ReadLine();
            if (int.Parse(result) == firstNumber + secondNumber)
            {
                score++;
                Console.WriteLine("Your answer was correct.");
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over! Your final score was {score}");
            }
        }

        Helpers.AddToHistory(score, GameType.Addition);
    }

    public void SubtractionGame(string message)
    {
        Console.WriteLine(message);
        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            string result = Console.ReadLine();
            if (int.Parse(result) == firstNumber - secondNumber)
            {
                score++;
                Console.WriteLine("Your answer was correct.");
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over! Your final score was {score}");
            }
        }

        Helpers.AddToHistory(score, GameType.Subtraction);
    }

    public void MultiplicationGame(string message)
    {
        Console.WriteLine(message);
        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 9);
            int secondNumber = random.Next(1, 9);

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            string result = Console.ReadLine();
            if (int.Parse(result) == firstNumber * secondNumber)
            {
                score++;
                Console.WriteLine("Your answer was correct.");
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over! Your final score was {score}");
            }
        }

        Helpers.AddToHistory(score, GameType.Multiplication);
    }

    public void DivisionGame(string message)
    {
        Console.WriteLine(message);
        var score = 0;
        for (var i = 0; i < 5; i++)
        {
            int[] divisionNumbers = Helpers.GetDivisionNumbers();
            int firstNumber = divisionNumbers[0];
            int secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");
            string result = Console.ReadLine();

            if (int.Parse(result) == firstNumber / secondNumber)
            {
                score++;
                Console.WriteLine("Your answer was correct.");
            }
            else
            {
                Console.WriteLine("Your answer was incorrect.");
            }

            if (i == 4)
            {
                Console.WriteLine($"Game over! Your final score was {score}");
            }
        }

        Helpers.AddToHistory(score, GameType.Division);
    }
}
using MathGame.Models;

namespace MathGame;

public class Helpers
{
    private static readonly List<Game> games = new()
    {
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 }
    };

    public static void GetGames()
    {
        var gamesToPrint = games.Where(x => x.Type == GameType.Division);

        Console.Clear();
        Console.WriteLine("------------------------");
        Console.WriteLine("Games History");

        foreach (var game in games) Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts.");
        Console.WriteLine("------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }


    public static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            }
        );
    }

    public static int[] GetDivisionNumbers()
    {
        var random = new Random();
        int firstNumber = random.Next(1, 99);
        int secondNumber = random.Next(1, 99);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result.SetValue(firstNumber, 0);
        result.SetValue(secondNumber, 1);


        return result;
    }

    public static string? ValidateResult(string result)
    {
        while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            result = Console.ReadLine();
        }

        return result;
    }

    public static string GetName()
    {
        Console.WriteLine("Please type your name");
        string name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cano not be empty.");
            name = Console.ReadLine();
        }

        return name;
    }
}
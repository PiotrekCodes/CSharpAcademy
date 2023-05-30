﻿namespace MathGame;

public class Helpers
{
    private static readonly List<string> games = new();

    public static void GetGames()
    {
        Console.Clear();
        Console.WriteLine("------------------------");
        Console.WriteLine("Games History");

        foreach (string game in games) Console.WriteLine(game);
        Console.WriteLine("------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }


    public static void AddToHistory(int gameScore, string gameType)
    {
        games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
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
}
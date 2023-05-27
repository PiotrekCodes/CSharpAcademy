﻿

DateTime date = DateTime.UtcNow; 
string name = GetName();

Menu(name);

string gameSelected = Console.ReadLine();

switch (gameSelected.Trim().ToLower())
{
    case "a":
        AdditionGame("Addition game selected");
        break;
    case "s":
        SubtractionGame("Subtraction game selected");
        break;
    case "m":
        MultiplicationGame("Multiplication game selected");
        break;
    case "d":
        DivisionGame("Division game selected");        
        break;
    case "q":
        Console.WriteLine("You selected Quit");
        Environment.Exit(1);
        break;
    default:
        Console.WriteLine("You did not select a valid option");
        break;
}


// METHODS

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}

void Menu(string? name)
{
    Console.WriteLine("------------------------");
    Console.WriteLine(
        $"Hello {name.ToUpper()}. This is your math's game. That's great that you're working on improving yourself\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program
");
    Console.WriteLine("------------------------");
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
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
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
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
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
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
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);
        
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
}


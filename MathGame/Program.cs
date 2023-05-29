var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

Menu(name);


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
    var isGameOn = true;
    do
    {
        Console.WriteLine(@"What game would you like to play today? Choose from the options below:
V - View Previous Games       
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program
");
        Console.WriteLine("------------------------");
        string gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game: ");
                break;
            case "s":
                SubtractionGame("Subtraction game: ");
                break;
            case "m":
                MultiplicationGame("Multiplication game: ");
                break;
            case "d":
                DivisionGame("Division game: ");
                break;
            case "q":
                Console.WriteLine("You selected Quit");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("You did not select a valid option");
                break;
        }
    } while (isGameOn);
}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("------------------------");
    Console.WriteLine("Games History");

    foreach (string game in games) Console.WriteLine(game);
    Console.WriteLine("------------------------\n");
    Console.WriteLine("Press any key to return to Main Menu");
    Console.ReadLine();
}

void AdditionGame(string message)
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

    AddToHistory(score, "Addition");
}

void SubtractionGame(string message)
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

    AddToHistory(score, "Subtraction");
}

void MultiplicationGame(string message)
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

    AddToHistory(score, "Multiplication");
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
    var score = 0;
    for (var i = 0; i < 5; i++)
    {
        int[] divisionNumbers = GetDivisionNumbers();
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

    AddToHistory(score, "Division");
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
}

int[] GetDivisionNumbers()
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
namespace MathGame;

public class Menu
{
    private readonly GameEngine gameEngine = new();

    public void ShowMenu(string? name, DateTime date)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine(
            $"Hello {name.ToUpper()}. It is {date}. This is your math's game. That's great that you're working on improving yourself\n");
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
                    Helpers.GetGames();
                    break;
                case "a":
                    gameEngine.AdditionGame("Addition game: ");
                    break;
                case "s":
                    gameEngine.SubtractionGame("Subtraction game: ");
                    break;
                case "m":
                    gameEngine.MultiplicationGame("Multiplication game: ");
                    break;
                case "d":
                    gameEngine.DivisionGame("Division game: ");
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
}
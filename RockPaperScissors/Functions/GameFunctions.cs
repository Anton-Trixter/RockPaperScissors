using RockPaperScissors.Enums;
using RockPaperScissors.Models;
namespace RockPaperScissors.Functions;

public static class GameFunctions
{
    public static void InitHumanPlayer(Player humanPlayer)
    {
        Console.WriteLine("Enter the name of human player: ");
        humanPlayer.Name = Console.ReadLine();
    }
    
    public static void InitCpuPlayer(Player cpuPlayer)
    {
        cpuPlayer.Name = "CPU";
    }
    
    public static void MenuForChooseTheGesture()
    {
        Console.WriteLine("Choose your gesture: ");
        Console.WriteLine(PlayerGesture.Rock);
        Console.WriteLine(PlayerGesture.Paper);
        Console.WriteLine(PlayerGesture.Scissors);
        // Console.WriteLine("1. Rock");
        // Console.WriteLine("2. Paper");
        // Console.WriteLine("3. Scissors");
    }
    
    public static void PrintTheResultsOfGame()
    {
        Console.WriteLine("Wins");
        Console.WriteLine("========");
        Console.WriteLine(humanPlayer.Name + ": " + playerWins);
        Console.WriteLine(cpuPlayer.Name + ": " + cpuWins);
        Console.WriteLine("Draw" + ": " + draw);
    }
    
    public static string PlayerInput()
    {
        string? humanGesture = Console.ReadLine();
        return humanGesture;
    }
    
    public static int CpuInput()
    {
        Random rand = new Random();
        int cpuGesture = rand.Next(1, 4);
    }
    
    public static void PrintTheError()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The value You have entered is not valid!");
        Console.ResetColor();
    }
    
    public static bool IsPlayerInputValid(string playerInput)
    {
        if (int.TryParse(playerInput, out int gesture))
        {
            if (gesture >= 1 && gesture <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
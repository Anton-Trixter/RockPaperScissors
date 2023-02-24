using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using RockPaperScissors;
namespace RockPaperScissors.Methods;

public static class GameMethods
{
    /// <summary>
    /// Gets the name of a human player from the user
    /// and checks that user are entered at least one symbol
    /// </summary>
    /// <param name="player">object of class "Player"</param>
    public static void InitHumanPlayer(Player player)
    {
        Console.WriteLine("Enter the name of human player: ");
        player.Name = Console.ReadLine();
        
        // if the player name is not appropriate
        while (player.Name == null)
        {
            Console.WriteLine("The name of the player is null!");
            Console.WriteLine("Enter the name of human player: ");
            player.Name = Console.ReadLine();
        }
    }

    public static void InitCpuPlayer(Player cpuPlayer)
    {
        cpuPlayer.Name = "CPU";
    }

    public static void InitGameReferee(Referee gameReferee)
    {
        gameReferee.PlayerWins = 0;
        gameReferee.CpuWins = 0;
        gameReferee.Draw = 0;
    }
    
    /// <summary>
    /// return "true" if the player name is appropriate
    /// </summary>
    /// <param name="name">The name of a player</param>
    /// <returns>boolean value (true or false)</returns>
    private static bool CheckThePlayerName(string? name)
    {
        if (name == null)
        {
            return false;
        }
        
        return true;
    }

    /// <summary>
    /// Prints a menu for choose the gesture of a player
    /// </summary>
    public static void MenuForChooseTheGesture()
    {
        Console.WriteLine("Choose your gesture: ");
        Console.WriteLine("0. " + "Exit the game because You don't like gambling games");
        Console.WriteLine("1. " + Gesture.Rock);
        Console.WriteLine("2. " + Gesture.Paper);
        Console.WriteLine("3. " + Gesture.Scissors);
    }
    
    /// <summary>
    /// Get the input from the player
    /// </summary>
    /// <returns>string with user input</returns>
    public static Gesture PlayerInput()
    {
        string? humanGesture = Console.ReadLine();

        while(!IsPlayerInputValid(humanGesture))
        {
            PrintTheError();
            MenuForChooseTheGesture();
            humanGesture = Console.ReadLine();
        }

        return (Gesture)int.Parse(humanGesture);
        //return int.Parse(humanGesture);
    }
    
    /// <summary>
    /// Get the random input from the CPU
    /// </summary>
    /// <returns>one of the digits (1, 2 or 3)</returns>
    public static Gesture CpuInput()
    {
        Random rand = new Random();
        int cpuGesture = rand.Next(1, 4);

        return (Gesture)cpuGesture;
    }
    
    /// <summary>
    /// Return "true" when the input from player is appropriate
    /// </summary>
    /// <param name="playerInput">the value which the user are typed in console</param>
    /// <returns>boolean value</returns>
    static bool IsPlayerInputValid(string? playerInput)
    {
        if (int.TryParse(playerInput, out int gesture))
        {
            if (gesture >= 0 && gesture <= 3)
            {
                return true;
            }
            
            return false;
        }

        return false;
    }
    
    public static void PrintTheResultsOfGame(Player human, Player cpu, Referee referee)
    {
        Console.WriteLine("Wins");
        Console.WriteLine("==========");
        Console.WriteLine(human.Name + ": " + referee.PlayerWins);
        Console.WriteLine(cpu.Name + ": " + referee.CpuWins);
        Console.WriteLine("Draw" + ": " + referee.Draw);
        Console.WriteLine("==========");
    }

    static void PrintTheError()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The value You have entered is not valid!");
        Console.ResetColor();
    }

    public static void ClearTheScreen()
    {
        Console.Clear();
    }
}
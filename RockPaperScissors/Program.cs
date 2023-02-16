using RockPaperScissors.Models;

namespace RockPaperScissors;

public class Program
{
    // Creating the objects of humanPlayer and cpuPlayer
    Player humanPlayer = new Player();
    Player cpuPlayer = new Player();

    // Give a name to the player
    InitHumanPlayer(humanPlayer);

    int playerWins;
    int cpuWins;
    int draw;
}
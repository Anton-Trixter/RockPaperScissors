using System;
using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using RockPaperScissors.Methods;

namespace RockPaperScissors
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
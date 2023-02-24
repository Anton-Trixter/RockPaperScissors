using System;
using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using RockPaperScissors.Methods;

// Creating the objects of humanPlayer and cpuPlayer
Player humanPlayer = new Player();
Player cpuPlayer = new Player();
Referee gameReferee = new Referee();

// Give a name to the player
GameMethods.InitHumanPlayer(humanPlayer);
GameMethods.InitCpuPlayer(cpuPlayer);
GameMethods.InitGameReferee(gameReferee);

// Print the menu for the player
GameMethods.ClearTheScreen();
GameMethods.MenuForChooseTheGesture();
// Get the gestures of players
humanPlayer.Gesture = GameMethods.PlayerInput();
cpuPlayer.Gesture = GameMethods.CpuInput();

while (humanPlayer.Gesture != 0)
{
    gameReferee.TellThePlayerGesture(humanPlayer.Gesture, cpuPlayer.Gesture);
    gameReferee.JudgeThePlayers(humanPlayer.Gesture, cpuPlayer.Gesture);
    GameMethods.PrintTheResultsOfGame(humanPlayer, cpuPlayer, gameReferee);
    
    GameMethods.MenuForChooseTheGesture();
    humanPlayer.Gesture = GameMethods.PlayerInput();
    cpuPlayer.Gesture = GameMethods.CpuInput();
}


Console.WriteLine("You are exited the game.");
using RockPaperScissors.Enums;
namespace RockPaperScissors.Models;

// The class which will be used to create players (cpu and human)
public class Player
{
    public string? Name {get; set;}
    public PlayerGesture PlayerGesture { get; set; }
}
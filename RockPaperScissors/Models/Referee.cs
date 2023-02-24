using RockPaperScissors.Enums;
namespace RockPaperScissors.Models;

public class Referee
{
    public int PlayerWins { get; set; }
    public int CpuWins { get; set; }
    public int Draw { get; set; }

    public void TellThePlayerGesture(Gesture humanGesture, Gesture cpuGesture)
    {
        Console.WriteLine($"The Player gesture is: {humanGesture}");
        Console.WriteLine($"The CPU gesture is: {cpuGesture}");    
    }
    public void JudgeThePlayers(Gesture humanGesture, Gesture cpuGesture)
    {
        if (humanGesture == cpuGesture)
        {
            Draw++;
            return;
        }
        
        if (humanGesture == Gesture.Paper && cpuGesture == Gesture.Rock ||
            humanGesture == Gesture.Rock && cpuGesture == Gesture.Scissors ||
            humanGesture == Gesture.Scissors && cpuGesture == Gesture.Paper
            )
        {
            PlayerWins++;
            Console.WriteLine("The Player wins!");
            return;
        }

        CpuWins++;
        Console.WriteLine("The CPU wins!");
        
        // if (humanGesture == Gesture.Paper && cpuGesture == Gesture.Scissors ||
        //     humanGesture == Gesture.Rock && cpuGesture == Gesture.Paper ||
        //     humanGesture == Gesture.Scissors && cpuGesture == Gesture.Rock
        //     )
        // {
        //     CpuWins++;
        //     Console.WriteLine("The CPU wins!");
        // }
    }
}
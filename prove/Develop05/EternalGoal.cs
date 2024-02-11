using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine("Congrats on your progress with this goal");
        Console.WriteLine($"You have scored {_points} points");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}
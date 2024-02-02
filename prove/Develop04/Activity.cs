using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do this activity?");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job on the {_name}");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
    }

    public void ShowSpinners(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("x");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b \b\b");
        }
    }
}
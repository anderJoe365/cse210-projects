using System;

public class BreatingActivity : Activity
{
    public BreatingActivity()
    {
        _name = "Breating Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        string response = Console.ReadLine();
        _duration = int.Parse(response);
        Console.WriteLine("Get Ready...");
        ShowSpinners(6);
        DateTime begin = DateTime.Now;
        DateTime stop = begin.AddSeconds(_duration);

        while (DateTime.Now < stop)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe Out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
        ShowSpinners(6);
    }
}
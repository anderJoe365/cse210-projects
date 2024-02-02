using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listening Activity";
        _description = "";
        _duration = 0;

        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heros?");
    }

    public void Run()
    {
         DisplayStartingMessage();
        string response = Console.ReadLine();
        _duration = int.Parse(response);
        string prompt = GetRandomPrompt();
        Console.WriteLine("Make a list answering this prompt.");
        Console.WriteLine($"----{prompt}----");
        Console.WriteLine("Get Ready");
        ShowSpinners(8);
        DateTime begin = DateTime.Now;
        DateTime stop = begin.AddSeconds(_duration);

        while (DateTime.Now < stop)
        {
            response = Console.ReadLine();
            _count ++;
        }

        Console.WriteLine($"You wrote {_count} responses");
        DisplayEndingMessage();
        ShowSpinners(4);
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();

        int j = randomGenerator.Next(_prompts.Count);

        return _prompts[j];
    }

    
}
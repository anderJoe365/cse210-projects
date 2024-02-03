using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;

        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you did something truly selfless");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How do you feel when it was completed?");
        _questions.Add("What made this time different than the other times when you were not as successful?");
        _questions.Add("What is you favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        DisplayStartingMessage();
        string response = Console.ReadLine();
        _duration = int.Parse(response);
        string prompt = GetRandomPrompt();
        Console.WriteLine("Think about this prompt.");
        Console.WriteLine($"----{prompt}----");
        Console.WriteLine("Get Ready");
        ShowSpinners(8);
        DateTime begin = DateTime.Now;
        DateTime stop = begin.AddSeconds(_duration);

        while (DateTime.Now < stop)
        {
            Console.WriteLine("");
            DisplayQuestions();
            response = Console.ReadLine();
        }

        DisplayEndingMessage();
        ShowSpinners(4);
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();

        int j = randomGenerator.Next(_prompts.Count);

        return _prompts[j];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();

        int j = randomGenerator.Next(_questions.Count);

        return _questions[j];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }
}
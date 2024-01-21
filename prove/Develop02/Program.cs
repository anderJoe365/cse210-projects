using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;



Journal journal = new Journal();

Console.WriteLine("Welcome to your Journal! What would you like to do?");
int number = 0;

while (number != 5)
{
    Console.WriteLine("1: New Entry");
    Console.WriteLine("2: Display Entry");
    Console.WriteLine("3: Save");
    Console.WriteLine("4: Load");
    Console.WriteLine("5: Quit");
    
    number = int.Parse(Console.ReadLine());


    if (number == 1)
    {
        Entry newEntry = new Entry();

        PromptGenerator promptGenerator = new PromptGenerator();
        DateTime currentTime = DateTime.Now;
        newEntry._date = currentTime.ToShortDateString();
        string Prompt = promptGenerator.GetRandomPrompt();
        newEntry._promptText = Prompt;
        newEntry.Display();
        newEntry._entryText = Console.ReadLine();

    
        journal.AddEntry(newEntry);
        
    }
    else if (number == 2)
    {
        journal.DisplayAll();
    }
    else if (number == 3)
    {
        Console.WriteLine("What is the filename you would like to save to?");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
    }
    else if (number == 4)
    {

        Console.WriteLine("What is the filename you want to load from?");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);

        
    }
    else if (number == 5)
    {
        Console.WriteLine("Have a wonderful day!");
    }
}

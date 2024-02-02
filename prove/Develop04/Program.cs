using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;


        while (userInput != 4)
        {
            Console.WriteLine("Welcome to the Mindfulness program");
            Console.WriteLine("Please choose and activity from the selection.");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Listing Activity");
            Console.WriteLine("3: Reflection Activity");
            Console.WriteLine("4: Quit");
            userInput = int.Parse(Console.ReadLine());
            
            if (userInput == 1)
            {
                BreatingActivity breathe = new BreatingActivity();
                breathe.Run();

            }
            else if (userInput == 2)
            {
                ListingActivity list = new ListingActivity();
                list.Run();
            }
            else if (userInput == 3)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }
            else if (userInput == 4)
            {
                Console.WriteLine("We hope to see you again soon!");
                Console.WriteLine("Whave a wonderful day!");
            }
        }
    }
}
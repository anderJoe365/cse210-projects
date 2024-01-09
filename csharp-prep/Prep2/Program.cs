using System;

class Program
{
    static void Main(string[] args)
    {

        String letters = "";

        Console.Write("What is the grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        if (percentage >= 90)
        {
            letters = "A";
        }
        else if (percentage >= 80)
        {
            letters = "B";
        }
        else if (percentage >= 70)
        {
            letters = "C";
        }
        else if (percentage >= 60)
        {
            letters = "D";
        }
        else
        {
            letters = "F";
        }

        Console.WriteLine(letters);

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations!! You passed!!");
        }
        else 
        {
            Console.Write("I'm sorry, You will need to retake this class.");
        }
    }
}
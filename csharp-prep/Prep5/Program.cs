using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResults(userName, squared);
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int squared = userNumber * userNumber;

            return squared;   
        }

        static void DisplayResults(string userName, int squared)
        {
            Console.WriteLine($"{userName}, your number squared is {squared}");
        }
    }
}